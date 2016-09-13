using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSLibrary;
using CSLibrary.Constants;
using CSLibrary.Structures;
using System.Threading;


namespace MDWlite
{
    class CS203
    {
        public static bool Plugged = false;
        public static HighLevelInterface Reader = new CSLibrary.HighLevelInterface();
        public static CSLibrary.Constants.Result ret = CSLibrary.Constants.Result.OK;
        private static object MyLock = new object();
        public static double EPCount = 1;
        public static System.Timers.Timer aTimer = new System.Timers.Timer(900);
        public static bool Connect(string IP)
        {
            Plugged = false;
            try
            {   
                if ((Reader.State == RFState.IDLE) || (Reader.State == RFState.RESET))
                {
                    if ((ret = Reader.Connect(IP, 3000)) != CSLibrary.Constants.Result.OK)
                    {
                        return false;
                    }
                    else
                    {
                        Plugged = true;
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void SetPort(bool P0, bool P1)
        {
            if (Reader.State == RFState.BUSY)
            {
                Reader.SetGPO0Status(P0);
                Reader.SetGPO1Status(P1);
            }
        }
        public static void SetBit(int b, bool V)
        {
            if (Reader.State == RFState.BUSY)
            {
                if(b==0)
                    Reader.SetGPO0Status(V);
                else if (b==1)
                    Reader.SetGPO1Status(V);
            }
        }
        public static bool Pause()
        {
            if (Reader.State == RFState.BUSY)
            {
                try
                {
                    Reader.StopOperation(true);
                    while (Reader.State != RFState.IDLE)
                        Thread.Sleep(100);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
        public static bool Play(int PWR)
        {
            try
            {
                if (Reader.State == RFState.IDLE)
                {
                    try
                    {
                        DynamicQParms m_dynQ = new DynamicQParms();
                        Reader.SetOperationMode(RadioOperationMode.CONTINUOUS);
                        //Program.ReaderXP.SetOperationMode(RadioOperationMode.CONTINUOUS);
                        Reader.SetTagGroup(Selected.ALL, CSLibrary.Constants.Session.S0, SessionTarget.A);
                        //Program.ReaderXP.SetSingulationAlgorithmParms(Program.appSetting.Singulation, Program.appSetting.SingulationAlg);
                        Reader.SetSingulationAlgorithmParms(SingulationAlgorithm.DYNAMICQ, m_dynQ);
                        Reader.SetDynamicQParms(7, 0, 15, 0, 4, 1);

                        Reader.Options.TagRanging.multibanks = 0;//
                        Reader.Options.TagRanging.flags = SelectFlags.ZERO;
                        //Reader.Name = time;

                        Reader.Options.TagRanging.QTMode = false; // reset to default
                        Reader.Options.TagRanging.accessPassword = 0x0; // reset to default

                        Reader.SetPowerLevel((uint)PWR);
                        Reader.StartOperation(Operation.TAG_RANGING, false);
                        //TimeMonitor(true);
                        //aTimer.Start();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //MessageBoxEx.Show(String.Format("Imposible Establecer Conexión con la dirección {0} debido a: {1}", IP, ex.ToString()));
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(String.Format("Aquí está en el play interno: {0}", ex.ToString()));
                return false;
            }
        }
        public static bool Stop()
        {
            try
            {
                Reader.Disconnect();
                Plugged = false;
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public static void ReaderFull_StateChangedEvent(object sender, CSLibrary.Events.OnStateChangedEventArgs e)
        {
            try
            {
                switch (e.state)
                {
                    case RFState.IDLE:
                        break;
                    case RFState.BUSY:
                        break;
                    case RFState.RESET:
                        break;
                    case RFState.ABORT:
                        break;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(String.Format("Aquí está en estados internos: {0}", ex.ToString()));

            }
        }
        public static void ReaderFull_TagInventoryEvent(object sender, CSLibrary.Events.OnAsyncCallbackEventArgs e)
        {
            //Interlocked.Increment(ref totaltags);
            try
            {
                CSLibrary.HighLevelInterface u = (CSLibrary.HighLevelInterface)sender;
                lock (MyLock)
                {
                    if ((!e.info.crcInvalid) && (e.info.epc.ToString().Length == 24))
                    {
                        EPCread epcNew = new EPCread()
                        {
                            _epc = e.info.epc.ToString(),
                            _ip = u.IPAddress.ToString(),
                            _rssi = e.info.rssi.ToString(),
                            _datetime = DateTime.Now.ToString()
                        };

                        //if (EPCs.Count > 0)
                        //{
                        EPCread epcIn = EPCs.Find(delegate(EPCread nn) { return (nn._epc == e.info.epc.ToString()); });
                        if (epcIn == null)
                        {
                            epcNew._id = EPCount++.ToString();
                            epcNew._counter = "0";
                            EPCs.Insert(0, epcNew);
                        }
                        else
                        {
                            epcIn._datetime = DateTime.Now.ToString();
                            epcIn._counter = (int.Parse(epcIn._counter) + 1).ToString();
                            epcIn._rssi = e.info.rssi.ToString();
                        }
                        return;
                        //}
                        //epcNew.ID = EPCount++.ToString();
                        //EPCs.Insert(0, epcNew);
                    }
                }   
            }
            catch (Exception ex)
            {
                //MessageBox.Show(String.Format("Aquí está en inventory interno: {0}", ex.ToString()));
            }
        }
        //HANDLERS
        public static void Handlers(bool status)
        {
            if (status)
            {
                Reader.OnStateChanged += new EventHandler<CSLibrary.Events.OnStateChangedEventArgs>(ReaderFull_StateChangedEvent);
                Reader.OnAsyncCallback += new EventHandler<CSLibrary.Events.OnAsyncCallbackEventArgs>(ReaderFull_TagInventoryEvent);
                aTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
                aTimer.Start();
            }
            else
            {
                Reader.OnStateChanged -= new EventHandler<CSLibrary.Events.OnStateChangedEventArgs>(ReaderFull_StateChangedEvent);
                Reader.OnAsyncCallback -= new EventHandler<CSLibrary.Events.OnAsyncCallbackEventArgs>(ReaderFull_TagInventoryEvent);
                aTimer.Elapsed -= new System.Timers.ElapsedEventHandler(OnTimedEvent);
            }
        }
        //CONSTRUCTORES
        public static List<EPCread> EPCs = new List<EPCread>();
        public class EPCread
        {
            public string _ip { get; set; }
            public string _id { get; set; }
            public string _epc { get; set; }
            public string _rssi { get; set; }
            public string _counter { get; set; }
            public string _datetime { get; set; }
        }
        //CUSTOM
        public static string getOneEPC()
        {
            if (Plugged)
            {
                Pause();
                //EPCs.Clear();
                Play(Program.appSetting.PowerVal);
                //int dec = 1000;
                //while (dec > 0)
                //    dec--;
                if (EPCs.Count > 0)
                    return EPCs[0]._epc;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }
        //MÉTODO DE TIMER INTERNO PARA BORRAR REGISTROS QUE SOBREPASEN SU TIEMPO
        private static void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;
            try
            {
                lock (MyLock)
                {
                    int timeIP = Program.appSetting.maxRelation;
                    foreach (EPCread _epcs in EPCs)
                    {
                        TimeSpan dif = now.Subtract(Convert.ToDateTime(_epcs._datetime));
                        //if (dif.Milliseconds > timeIP)
                        if (dif.Seconds > Program.appSetting.numBorrar)
                        {
                            EPCs.Remove(_epcs);
                        }
                    }
                }
            }
            catch (Exception ex){}
        }
    }
}

