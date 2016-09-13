using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

using CSLibrary.Structures;
using CSLibrary.Constants;

namespace MDWlite
{
    [Serializable]
    public class AppSettings
    {
        #region private Fields
        private bool m_enableRssiFilter = false;

        private uint m_RssiFilterThreshold = 60;

        private uint m_link_profile = 2;

        private uint m_power = 300;

        private bool m_fixedChannel = false;

        private uint m_channel_number = 0;

        private bool m_lbt = false;

        private bool m_cfg_blocking_mode = false;

        private bool m_cfg_continuous_mode = true;
   
        private bool m_debug_log = false;

        private RegionCode region = RegionCode.UNKNOWN;

        private TagGroup m_tagGroup = new TagGroup();


        private FixedQParms m_fixedQ = new FixedQParms();
        private DynamicQParms m_dynQ = new DynamicQParms();
        private SingulationAlgorithm m_singulation = SingulationAlgorithm.DYNAMICQ;
        private SingulationAlgorithmParms m_singulationAlgorithm = new SingulationAlgorithmParms();

        private string _Server;
        private string _DB;
        //private string _User;
        private string _Pass;
    
        private string _SDFpath;

        private string _ImagePath;

        private string _User_HH;

        //DEMO FIELDS ANTENNA
        private string _IP = ""; 
        private int _Power = 0;

        //DEMO FIELDS OPERATIONS
        private int _maxRelation = 30;
        private int _numBorrar = 3;

        private int _bitSuccess = 0;
        private int _TONsuccess = 0;
        private int _TOFFsuccess = 0;
        private int _Nsuccess = 0;

        private int _bitError = 0;
        private int _TONerror = 0;
        private int _TOFFerror = 0;
        private int _Nerror = 0;

        //USERS
        private List<User> _Users = new List<User>();
        private List<Tablet> _Tablets = new List<Tablet>();
        #endregion

        #region Constructors

        public AppSettings()
        {
            //inital here
            m_tagGroup.selected = Selected.ALL;
            m_tagGroup.session = Session.S0;
            m_tagGroup.target = SessionTarget.A;

            m_dynQ.thresholdMultiplier = 0;
            m_dynQ.maxQValue = 15;
            m_dynQ.minQValue = 0;
            m_dynQ.retryCount = 0;
            m_dynQ.startQValue = 7;
            m_dynQ.toggleTarget = 1;


            m_fixedQ.qValue = 7;
            m_fixedQ.repeatUntilNoTags = 0;
            m_fixedQ.retryCount = 0;
            m_fixedQ.toggleTarget = 1;

            m_singulation = SingulationAlgorithm.DYNAMICQ;
            
            //m_power = Program.ReaderCE.GetActiveMaxPowerLevel ();
        }

        #endregion

        #region Public properties
        public bool EnableRssiFilter
        {
            get { return m_enableRssiFilter; }
            set { m_enableRssiFilter = value; }
        }
        public uint RssiFilterThreshold
        {
            get { return m_RssiFilterThreshold; }
            set { m_RssiFilterThreshold = value; }
        }
        public bool Debug_log
        {
            get { return m_debug_log; }
            set { m_debug_log = value; }
        }

        public bool Cfg_blocking_mode
        {
            get { return m_cfg_blocking_mode; }
            set { m_cfg_blocking_mode = value; }
        }
        public bool Cfg_continuous_mode
        {
            get { return m_cfg_continuous_mode; }
            set { m_cfg_continuous_mode = value; }
        }
        public RegionCode Region
        {
            get { return region; }
            set { region = value; }
        }
        public uint Link_profile
        {
            get { return m_link_profile; }
            set { m_link_profile = value; }
        }
        public uint Power
        {
            get { return m_power; }
            set { m_power = value; }
        }
        public bool FixedChannel
        {
            get { return m_fixedChannel; }
            set { m_fixedChannel = value; }
        }
        public uint Channel_number
        {
            get { return m_channel_number; }
            set { m_channel_number = value; }
        }
        public bool Lbt
        {
            get { return m_lbt; }
            set { m_lbt = value; }
        }
        public SingulationAlgorithm Singulation
        {
            get { return m_singulation; }
            set { m_singulation = value; }
        }
        public SingulationAlgorithmParms SingulationAlg
        {
            get 
            { 
                switch(m_singulation)
                {
                    case SingulationAlgorithm.DYNAMICQ:
                        return m_dynQ;
                    case SingulationAlgorithm.FIXEDQ:
                        return m_fixedQ;
                    default:
                        return new SingulationAlgorithmParms();
                }
            }
            set 
            {
                if (value.GetType() == typeof(DynamicQParms))
                {
                    m_dynQ = (DynamicQParms)value;
                }
                else if (value.GetType() == typeof(FixedQParms))
                {
                    m_fixedQ = (FixedQParms)value;
                }
                m_singulationAlgorithm = value;
            }
        }
        public FixedQParms FixedQ
        {
            get { return m_fixedQ; }
            set { m_fixedQ = value; }
        }
        public DynamicQParms DynQ
        {
            get { return m_dynQ; }
            set { m_dynQ = value; }
        }
        public TagGroup tagGroup
        {
            get { return m_tagGroup; }
            set { m_tagGroup = value; }
        }
        public String Server
        {
            get { return _Server; }
            set { _Server = value; }
        }
        public String DB
        {
            get { return _DB; }
            set { _DB = value; }
        }
        //public String User
        //{
        //    get { return _User; }
        //    set { _User = value; }
        //}
        public String Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }
        public String SDFpath
        {
            get { return _SDFpath; }
            set { _SDFpath = value; }
        }
        public String ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }
        public String User_HH
        {
            get { return _User_HH; }
            set { _User_HH = value; }
        }
        //DEMO FIELDS ANTENNA
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }
        //DEMO FIELDS OPERATION
        public int PowerVal
        {
            get { return _Power; }
            set { _Power = value; }
        }
        public int maxRelation
        {
            get { return _maxRelation; }
            set { _maxRelation = value; }
        }
        public int bitSuccess
        {
            get { return _bitSuccess; }
            set { _bitSuccess = value; }
        }
        public int TONsuccess
        {
            get { return _TONsuccess; }
            set { _TONsuccess = value; }
        }
        public int TOFFsuccess
        {
            get { return _TOFFsuccess; }
            set { _TOFFsuccess = value; }
        }
        public int Nsuccess
        {
            get { return _Nsuccess; }
            set { _Nsuccess = value; }
        }
        public int bitError
        {
            get { return _bitError; }
            set { _bitError = value; }
        }
        public int TONerror
        {
            get { return _TONerror; }
            set { _TONerror = value; }
        }
        public int TOFFerror
        {
            get { return _TOFFerror; }
            set { _TOFFerror = value; }
        }
        public int Nerror
        {
            get { return _Nerror; }
            set { _Nerror = value; }
        }
        public int numBorrar
        {
            get { return _numBorrar; }
            set { _numBorrar = value; }
        }
        ////USERS
        public List<User> Users
        {
            get { return _Users; }
            set { _Users = value; }
        }
        public List<Tablet> Tablets
        {
            get { return _Tablets; }
            set { _Tablets = value; }
        }
        #endregion

        #region Methods: Save, Load

        /// <summary>
        /// Saves this settings object to desired location
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(string fileName)
        {
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new XmlSerializer(typeof(AppSettings));
            // To write to a file, create a StreamWriter object.
            StreamWriter myWriter = new StreamWriter(fileName);
            mySerializer.Serialize(myWriter, this);
            myWriter.Close();
        }
        /// <summary>
        /// Saves this settings object to desired location
        /// </summary>
        public bool Save()
        {
            try
            {
                // Insert code to set properties and fields of the object.
                XmlSerializer mySerializer = new XmlSerializer(typeof(AppSettings));
                // To write to a file, create a StreamWriter object.
                StreamWriter myWriter = new StreamWriter(Program.applicationSettings);
                mySerializer.Serialize(myWriter, this);
                myWriter.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Returns a clsSettings object, loaded from a specific location
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public AppSettings Load(string fileName)
        {
            // Constructs an instance of the XmlSerializer with the type
            // of object that is being deserialized.
            XmlSerializer mySerializer = new XmlSerializer(typeof(AppSettings));
            // To read the file, creates a FileStream.
            FileStream myFileStream = new FileStream(fileName, FileMode.Open);
            // Calls the Deserialize method and casts to the object type.
            AppSettings pos = (AppSettings)mySerializer.Deserialize(myFileStream);
            myFileStream.Close();
            return pos;
        }

        /// <summary>
        /// Returns a clsSettings object, loaded from a specific location
        /// </summary>
        public AppSettings Load()
        {
            // Constructs an instance of the XmlSerializer with the type
            // of object that is being deserialized.
            XmlSerializer mySerializer = new XmlSerializer(typeof(AppSettings));
            // To read the file, creates a FileStream.
            FileStream myFileStream = new FileStream(Program.applicationSettings, FileMode.Open);
            // Calls the Deserialize method and casts to the object type.
            AppSettings pos = (AppSettings)mySerializer.Deserialize(myFileStream);
            myFileStream.Close();
            return pos;
        }
        #endregion

        #region Classes
        [Serializable]
        public class User
        {
            public string _id { get; set; }
            public string _name { get; set; }
            public string _lastname { get; set; }
            public string _tablet { get; set; }
            public string _epcE { get; set; }
        }
        [Serializable]
        public class Tablet
        {
            public string _id { get; set; }
            public string _marca { get; set; }
            public string _modelo { get; set; }
            public string _epcT { get; set; }
            public string _status { get; set; }
            public string _datetime { get; set; }
        }

        
        #endregion
    }
}
