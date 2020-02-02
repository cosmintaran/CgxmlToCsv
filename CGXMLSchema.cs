using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CgxmlToCsv
{


    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class CGXML
    {

        // private object[] itemsField;
        private CGXMLAddress[] addressField;

        private CGXMLBuilding[] buildingField;

        private CGXMLBuildingCommonParts[] buildingBommonParts;

        private CGXMLContested[] contested;

        private CGXMLContestedxEntity[] contestedXEntity;

        private CGXMLDeed[] deedField;

        private CGXMLFileDescription fileDescriptionField;

        private CGXMLLand landField;

        private CGXMLIU[] iu;

        private CGXMLParcel[] parcelField;

        private CGXMLPerson[] personField;

        private CGXMLPoints[] pointsField;

        private CGXMLRegistration[] registrationField;

        private CGXMLRegistrationXEntity[] registrationXEntityField;


        [XmlElement("Address", typeof(CGXMLAddress), Form = XmlSchemaForm.Unqualified)]
        public CGXMLAddress[] Address
        {
            get
            {
                return addressField;
            }
            set
            {
                addressField = value;
            }
        }

        [XmlElement("Building", typeof(CGXMLBuilding), Form = XmlSchemaForm.Unqualified)]
        public CGXMLBuilding[] Building
        {
            get
            {
                return buildingField;
            }
            set
            {
                buildingField = value;
            }
        }

        [XmlElement("BuildingCommonParts", typeof(CGXMLBuildingCommonParts), Form = XmlSchemaForm.Unqualified)]
        public CGXMLBuildingCommonParts[] BuildingCommonParts
        {
            get
            {
                return buildingBommonParts;
            }
            set
            {
                buildingBommonParts = value;
            }
        }

        [XmlElement("Contested", typeof(CGXMLContested), Form = XmlSchemaForm.Unqualified)]
        public CGXMLContested[] Contested
        {
            get
            {
                return contested;
            }
            set
            {
                contested = value;
            }
        }

        [XmlElement("ContestedxEntity", typeof(CGXMLContestedxEntity), Form = XmlSchemaForm.Unqualified)]
        public CGXMLContestedxEntity[] ContestedXEntity
        {
            get
            {
                return contestedXEntity;
            }
            set
            {
                contestedXEntity = value;
            }
        }

        [XmlElement("Deed", typeof(CGXMLDeed), Form = XmlSchemaForm.Unqualified)]
        public CGXMLDeed[] Deed
        {
            get
            {
                return deedField;
            }
            set
            {
                deedField = value;
            }
        }

        [XmlElement("FileDescription", typeof(CGXMLFileDescription), Form = XmlSchemaForm.Unqualified)]
        public CGXMLFileDescription FileDescription
        {
            get
            {
                return fileDescriptionField;
            }
            set
            {
                fileDescriptionField = value;
            }
        }

        [XmlElement("Land", typeof(CGXMLLand), Form = XmlSchemaForm.Unqualified)]
        public CGXMLLand Land
        {
            get
            {
                return landField;
            }
            set
            {
                landField = value;
            }
        }

        [XmlElement("IU", typeof(CGXMLIU), Form = XmlSchemaForm.Unqualified)]
        public CGXMLIU[] IU
        {
            get
            {
                return iu;
            }
            set
            {
                iu = value;
            }
        }

        [XmlElement("Parcel", typeof(CGXMLParcel), Form = XmlSchemaForm.Unqualified)]
        public CGXMLParcel[] Parcel
        {
            get
            {
                return parcelField;
            }
            set
            {
                parcelField = value;
            }
        }

        [XmlElement("Person", typeof(CGXMLPerson), Form = XmlSchemaForm.Unqualified)]
        public CGXMLPerson[] Person
        {
            get
            {
                return personField;
            }
            set
            {
                personField = value;
            }
        }

        [XmlElement("Points", typeof(CGXMLPoints), Form = XmlSchemaForm.Unqualified)]
        public CGXMLPoints[] Points
        {
            get
            {
                return pointsField;
            }
            set
            {
                pointsField = value;
            }
        }

        [XmlElement("Registration", typeof(CGXMLRegistration), Form = XmlSchemaForm.Unqualified)]
        public CGXMLRegistration[] Registration
        {
            get
            {
                return registrationField;
            }
            set
            {
                registrationField = value;
            }
        }


        [XmlElement("RegistrationXEntity", typeof(CGXMLRegistrationXEntity), Form = XmlSchemaForm.Unqualified)]
        public CGXMLRegistrationXEntity[] RegistrationXEntity
        {
            get
            {
                return registrationXEntityField;
            }
            set
            {
                registrationXEntityField = value;
            }
        }

    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLAddress
    {

        private int aDDRESSIDField;

        private string sIRSUPField;

        private string sIRUTAField;

        private bool iNTRAVILANField;

        private string dISTRICTTYPEField;

        private string dISTRICTNAMEField;

        private string sTREETTYPEField;

        private string sTREETNAMEField;

        private string pOSTALNUMBERField;

        private string bLOCKField;

        private string eNTRYField;

        private string fLOORField;

        private string aPNOField;

        private string zIPCODEField;

        private string dESCRIPTIONField;

        private string sECTIONField;

        public CGXMLAddress()
        {
            iNTRAVILANField = false;
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int ADDRESSID
        {
            get
            {
                return aDDRESSIDField;
            }
            set
            {
                aDDRESSIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string SIRSUP
        {
            get
            {
                return sIRSUPField;
            }
            set
            {
                sIRSUPField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string SIRUTA
        {
            get
            {
                return sIRUTAField;
            }
            set
            {
                sIRUTAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        [DefaultValue(false)]
        public bool INTRAVILAN
        {
            get
            {
                return iNTRAVILANField;
            }
            set
            {
                iNTRAVILANField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DISTRICTTYPE
        {
            get
            {
                return dISTRICTTYPEField;
            }
            set
            {
                dISTRICTTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DISTRICTNAME
        {
            get
            {
                return dISTRICTNAMEField;
            }
            set
            {
                dISTRICTNAMEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string STREETTYPE
        {
            get
            {
                return sTREETTYPEField;
            }
            set
            {
                sTREETTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string STREETNAME
        {
            get
            {
                return sTREETNAMEField;
            }
            set
            {
                sTREETNAMEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string POSTALNUMBER
        {
            get
            {
                return pOSTALNUMBERField;
            }
            set
            {
                pOSTALNUMBERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string BLOCK
        {
            get
            {
                return bLOCKField;
            }
            set
            {
                bLOCKField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ENTRY
        {
            get
            {
                return eNTRYField;
            }
            set
            {
                eNTRYField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string FLOOR
        {
            get
            {
                return fLOORField;
            }
            set
            {
                fLOORField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string APNO
        {
            get
            {
                return aPNOField;
            }
            set
            {
                aPNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ZIPCODE
        {
            get
            {
                return zIPCODEField;
            }
            set
            {
                zIPCODEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DESCRIPTION
        {
            get
            {
                return dESCRIPTIONField;
            }
            set
            {
                dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string SECTION
        {
            get
            {
                return sECTIONField;
            }
            set
            {
                sECTIONField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLBuilding
    {

        private int bUILDINGIDField;

        private int lANDIDField;

        private int aDDRESSIDField;

        private bool aDDRESSIDFieldSpecified;

        private int bUILDNOField;

        private double mEASUREDAREAField;

        private double tOTALAREAField;

        private string bUILDINGDESTINATIONField;

        private int lEVELSNOField;

        private bool lEVELSNOFieldSpecified;

        private int iUNOField;

        private double tAXVALUEField;

        private bool tAXVALUEFieldSpecified;

        private string nOTESField;

        private bool iSLEGALField;

        private double lEGALAREAField;

        private bool lEGALAREAFieldSpecified;

        private string e2IDENTIFIERField;

        private string pAPERCADNOField;

        private string pAPERLBNOField;

        private string tOPONOField;

        private string cADGENNOField;

        public CGXMLBuilding()
        {
            mEASUREDAREAField = 0D;
            tOTALAREAField = 0D;
            iUNOField = 0;
            iSLEGALField = true;
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDINGID
        {
            get
            {
                return bUILDINGIDField;
            }
            set
            {
                bUILDINGIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int LANDID
        {
            get
            {
                return lANDIDField;
            }
            set
            {
                lANDIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int ADDRESSID
        {
            get
            {
                return aDDRESSIDField;
            }
            set
            {
                aDDRESSIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ADDRESSIDSpecified
        {
            get
            {
                return aDDRESSIDFieldSpecified;
            }
            set
            {
                aDDRESSIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDNO
        {
            get
            {
                return bUILDNOField;
            }
            set
            {
                bUILDNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        [DefaultValue(0D)]
        public double MEASUREDAREA
        {
            get
            {
                return mEASUREDAREAField;
            }
            set
            {
                mEASUREDAREAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        [DefaultValue(0D)]
        public double TOTALAREA
        {
            get
            {
                return tOTALAREAField;
            }
            set
            {
                tOTALAREAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string BUILDINGDESTINATION
        {
            get
            {
                return bUILDINGDESTINATIONField;
            }
            set
            {
                bUILDINGDESTINATIONField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int LEVELSNO
        {
            get
            {
                return lEVELSNOField;
            }
            set
            {
                lEVELSNOField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool LEVELSNOSpecified
        {
            get
            {
                return lEVELSNOFieldSpecified;
            }
            set
            {
                lEVELSNOFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        [DefaultValue(0)]
        public int IUNO
        {
            get
            {
                return iUNOField;
            }
            set
            {
                iUNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TAXVALUE
        {
            get
            {
                return tAXVALUEField;
            }
            set
            {
                tAXVALUEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TAXVALUESpecified
        {
            get
            {
                return tAXVALUEFieldSpecified;
            }
            set
            {
                tAXVALUEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NOTES
        {
            get
            {
                return nOTESField;
            }
            set
            {
                nOTESField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public bool ISLEGAL
        {
            get
            {
                return iSLEGALField;
            }
            set
            {
                iSLEGALField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double LEGALAREA
        {
            get
            {
                return lEGALAREAField;
            }
            set
            {
                lEGALAREAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool LEGALAREASpecified
        {
            get
            {
                return lEGALAREAFieldSpecified;
            }
            set
            {
                lEGALAREAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string E2IDENTIFIER
        {
            get
            {
                return e2IDENTIFIERField;
            }
            set
            {
                e2IDENTIFIERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERCADNO
        {
            get
            {
                return pAPERCADNOField;
            }
            set
            {
                pAPERCADNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERLBNO
        {
            get
            {
                return pAPERLBNOField;
            }
            set
            {
                pAPERLBNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TOPONO
        {
            get
            {
                return tOPONOField;
            }
            set
            {
                tOPONOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CADGENNO
        {
            get
            {
                return cADGENNOField;
            }
            set
            {
                cADGENNOField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLBuildingCommonParts
    {

        private int bUILDINGCOMMONPARTIDField;

        private int bUILDINGIDField;

        private bool bUILDINGIDFieldSpecified;

        private string cOMMONPARTTYPEField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDINGCOMMONPARTID
        {
            get
            {
                return bUILDINGCOMMONPARTIDField;
            }
            set
            {
                bUILDINGCOMMONPARTIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDINGID
        {
            get
            {
                return bUILDINGIDField;
            }
            set
            {
                bUILDINGIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool BUILDINGIDSpecified
        {
            get
            {
                return bUILDINGIDFieldSpecified;
            }
            set
            {
                bUILDINGIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string COMMONPARTTYPE
        {
            get
            {
                return cOMMONPARTTYPEField;
            }
            set
            {
                cOMMONPARTTYPEField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLContested
    {

        private int cONTESTEDIDField;

        private int cONTESTEDNUMBERField;

        private bool cONTESTEDNUMBERFieldSpecified;

        private DateTime cONTESTEDDATEField;

        private bool cONTESTEDDATEFieldSpecified;

        private int sOLUTIONNUMBERField;

        private bool sOLUTIONNUMBERFieldSpecified;

        private DateTime sOLUTIONDATEField;

        private bool sOLUTIONDATEFieldSpecified;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int CONTESTEDID
        {
            get
            {
                return cONTESTEDIDField;
            }
            set
            {
                cONTESTEDIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int CONTESTEDNUMBER
        {
            get
            {
                return cONTESTEDNUMBERField;
            }
            set
            {
                cONTESTEDNUMBERField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool CONTESTEDNUMBERSpecified
        {
            get
            {
                return cONTESTEDNUMBERFieldSpecified;
            }
            set
            {
                cONTESTEDNUMBERFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public DateTime CONTESTEDDATE
        {
            get
            {
                return cONTESTEDDATEField;
            }
            set
            {
                cONTESTEDDATEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool CONTESTEDDATESpecified
        {
            get
            {
                return cONTESTEDDATEFieldSpecified;
            }
            set
            {
                cONTESTEDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int SOLUTIONNUMBER
        {
            get
            {
                return sOLUTIONNUMBERField;
            }
            set
            {
                sOLUTIONNUMBERField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool SOLUTIONNUMBERSpecified
        {
            get
            {
                return sOLUTIONNUMBERFieldSpecified;
            }
            set
            {
                sOLUTIONNUMBERFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public DateTime SOLUTIONDATE
        {
            get
            {
                return sOLUTIONDATEField;
            }
            set
            {
                sOLUTIONDATEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool SOLUTIONDATESpecified
        {
            get
            {
                return sOLUTIONDATEFieldSpecified;
            }
            set
            {
                sOLUTIONDATEFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLContestedxEntity
    {

        private int cONTESTEDXENTITYIDField;

        private int cONTESTEDIDField;

        private bool cONTESTEDIDFieldSpecified;

        private int lANDIDField;

        private bool lANDIDFieldSpecified;

        private int bUILDINGIDField;

        private bool bUILDINGIDFieldSpecified;

        private int iUIDField;

        private bool iUIDFieldSpecified;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int CONTESTEDXENTITYID
        {
            get
            {
                return cONTESTEDXENTITYIDField;
            }
            set
            {
                cONTESTEDXENTITYIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int CONTESTEDID
        {
            get
            {
                return cONTESTEDIDField;
            }
            set
            {
                cONTESTEDIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool CONTESTEDIDSpecified
        {
            get
            {
                return cONTESTEDIDFieldSpecified;
            }
            set
            {
                cONTESTEDIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int LANDID
        {
            get
            {
                return lANDIDField;
            }
            set
            {
                lANDIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool LANDIDSpecified
        {
            get
            {
                return lANDIDFieldSpecified;
            }
            set
            {
                lANDIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDINGID
        {
            get
            {
                return bUILDINGIDField;
            }
            set
            {
                bUILDINGIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool BUILDINGIDSpecified
        {
            get
            {
                return bUILDINGIDFieldSpecified;
            }
            set
            {
                bUILDINGIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int IUID
        {
            get
            {
                return iUIDField;
            }
            set
            {
                iUIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool IUIDSpecified
        {
            get
            {
                return iUIDFieldSpecified;
            }
            set
            {
                iUIDFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLDeed
    {

        private int dEEDIDField;

        private string dEEDNUMBERField;

        private DateTime dEEDDATEField;

        private bool dEEDDATEFieldSpecified;

        private string dEEDTYPEField;

        private string aUTHORITYField;

        private string nOTESField;

        private int fILEIDField;

        private string vALUECURRENCYField;

        private string vALUEAMOUNTField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int DEEDID
        {
            get
            {
                return dEEDIDField;
            }
            set
            {
                dEEDIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DEEDNUMBER
        {
            get
            {
                return dEEDNUMBERField;
            }
            set
            {
                dEEDNUMBERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public DateTime DEEDDATE
        {
            get
            {
                return dEEDDATEField;
            }
            set
            {
                dEEDDATEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool DEEDDATESpecified
        {
            get
            {
                return dEEDDATEFieldSpecified;
            }
            set
            {
                dEEDDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string DEEDTYPE
        {
            get
            {
                return dEEDTYPEField;
            }
            set
            {
                dEEDTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string AUTHORITY
        {
            get
            {
                return aUTHORITYField;
            }
            set
            {
                aUTHORITYField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NOTES
        {
            get
            {
                return nOTESField;
            }
            set
            {
                nOTESField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int FILEID
        {
            get
            {
                return fILEIDField;
            }
            set
            {
                fILEIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string VALUECURRENCY
        {
            get
            {
                return vALUECURRENCYField;
            }
            set
            {
                vALUECURRENCYField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string VALUEAMOUNT
        {
            get
            {
                return vALUEAMOUNTField;
            }
            set
            {
                vALUEAMOUNTField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLFileDescription
    {

        private string fILENAMEField;

        private DateTime eXPORTDATEField;

        private bool eXPORTDATEFieldSpecified;

        private string fILEVERSIONField;

        private string oPERATIONTYPEField;

        private string lICENSEDNAMEField;

        private string lICENSENUMBERField;

        private int fILEIDField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string FILENAME
        {
            get
            {
                return fILENAMEField;
            }
            set
            {
                fILENAMEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public DateTime EXPORTDATE
        {
            get
            {
                return eXPORTDATEField;
            }
            set
            {
                eXPORTDATEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EXPORTDATESpecified
        {
            get
            {
                return eXPORTDATEFieldSpecified;
            }
            set
            {
                eXPORTDATEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string FILEVERSION
        {
            get
            {
                return fILEVERSIONField;
            }
            set
            {
                fILEVERSIONField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string OPERATIONTYPE
        {
            get
            {
                return oPERATIONTYPEField;
            }
            set
            {
                oPERATIONTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string LICENSEDNAME
        {
            get
            {
                return lICENSEDNAMEField;
            }
            set
            {
                lICENSEDNAMEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string LICENSENUMBER
        {
            get
            {
                return lICENSENUMBERField;
            }
            set
            {
                lICENSENUMBERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int FILEID
        {
            get
            {
                return fILEIDField;
            }
            set
            {
                fILEIDField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLIU
    {

        private int iUIDField;

        private int bUILDINGIDField;

        private bool bUILDINGIDFieldSpecified;

        private string iDENTIFIERField;

        private string sECTIONField;

        private string aPNOField;

        private string eNTRYField;

        private double mEASUREDAREAField;

        private bool mEASUREDAREAFieldSpecified;

        private double tOTALAREAField;

        private bool tOTALAREAFieldSpecified;

        private string lANDINDIVISIONAREAField;

        private string cOMMONPARTSAREAField;

        private string nOTESField;

        private string fLOORField;

        private string lANDDIVISIONTYPEField;

        private string cOMMONPARTSTYPEField;

        private short rOOMNOField;

        private bool rOOMNOFieldSpecified;

        private string e2IDENTIFIERField;

        private string pAPERCADNOField;

        private string pAPERLBNOField;

        private string tOPONOField;

        private string cADGENNOField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int IUID
        {
            get
            {
                return iUIDField;
            }
            set
            {
                iUIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDINGID
        {
            get
            {
                return bUILDINGIDField;
            }
            set
            {
                bUILDINGIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool BUILDINGIDSpecified
        {
            get
            {
                return bUILDINGIDFieldSpecified;
            }
            set
            {
                bUILDINGIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IDENTIFIER
        {
            get
            {
                return iDENTIFIERField;
            }
            set
            {
                iDENTIFIERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string SECTION
        {
            get
            {
                return sECTIONField;
            }
            set
            {
                sECTIONField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string APNO
        {
            get
            {
                return aPNOField;
            }
            set
            {
                aPNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ENTRY
        {
            get
            {
                return eNTRYField;
            }
            set
            {
                eNTRYField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double MEASUREDAREA
        {
            get
            {
                return mEASUREDAREAField;
            }
            set
            {
                mEASUREDAREAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MEASUREDAREASpecified
        {
            get
            {
                return mEASUREDAREAFieldSpecified;
            }
            set
            {
                mEASUREDAREAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TOTALAREA
        {
            get
            {
                return tOTALAREAField;
            }
            set
            {
                tOTALAREAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TOTALAREASpecified
        {
            get
            {
                return tOTALAREAFieldSpecified;
            }
            set
            {
                tOTALAREAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string LANDINDIVISIONAREA
        {
            get
            {
                return lANDINDIVISIONAREAField;
            }
            set
            {
                lANDINDIVISIONAREAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string COMMONPARTSAREA
        {
            get
            {
                return cOMMONPARTSAREAField;
            }
            set
            {
                cOMMONPARTSAREAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NOTES
        {
            get
            {
                return nOTESField;
            }
            set
            {
                nOTESField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string FLOOR
        {
            get
            {
                return fLOORField;
            }
            set
            {
                fLOORField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string LANDDIVISIONTYPE
        {
            get
            {
                return lANDDIVISIONTYPEField;
            }
            set
            {
                lANDDIVISIONTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string COMMONPARTSTYPE
        {
            get
            {
                return cOMMONPARTSTYPEField;
            }
            set
            {
                cOMMONPARTSTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public short ROOMNO
        {
            get
            {
                return rOOMNOField;
            }
            set
            {
                rOOMNOField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ROOMNOSpecified
        {
            get
            {
                return rOOMNOFieldSpecified;
            }
            set
            {
                rOOMNOFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string E2IDENTIFIER
        {
            get
            {
                return e2IDENTIFIERField;
            }
            set
            {
                e2IDENTIFIERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERCADNO
        {
            get
            {
                return pAPERCADNOField;
            }
            set
            {
                pAPERCADNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERLBNO
        {
            get
            {
                return pAPERLBNOField;
            }
            set
            {
                pAPERLBNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TOPONO
        {
            get
            {
                return tOPONOField;
            }
            set
            {
                tOPONOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CADGENNO
        {
            get
            {
                return cADGENNOField;
            }
            set
            {
                cADGENNOField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLLand
    {

        private int lANDIDField;

        private string cADSECTORField;

        private int aDDRESSIDField;

        private bool aDDRESSIDFieldSpecified;

        private double mEASUREDAREAField;

        private double pARCELLEGALAREAField;

        private bool pARCELLEGALAREAFieldSpecified;

        private bool iSNEWField;

        private int fILEIDField;

        private bool fILEIDFieldSpecified;

        private double bUILDINGLEGALAREAField;

        private bool bUILDINGLEGALAREAFieldSpecified;

        private double tAXVALUEField;

        private bool tAXVALUEFieldSpecified;

        private string nOTESField;

        private bool eNCLOSEDField;

        private bool eNCLOSEDFieldSpecified;

        private bool cOAREAField;

        private bool cOAREAFieldSpecified;

        private string e2IDENTIFIERField;

        private string pAPERCADNOField;

        private string pAPERLBNOField;

        private string tOPONOField;

        private string cADGENNOField;

        public CGXMLLand()
        {
            mEASUREDAREAField = 0D;
            iSNEWField = true;
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int LANDID
        {
            get
            {
                return lANDIDField;
            }
            set
            {
                lANDIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CADSECTOR
        {
            get
            {
                return cADSECTORField;
            }
            set
            {
                cADSECTORField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int ADDRESSID
        {
            get
            {
                return aDDRESSIDField;
            }
            set
            {
                aDDRESSIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ADDRESSIDSpecified
        {
            get
            {
                return aDDRESSIDFieldSpecified;
            }
            set
            {
                aDDRESSIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double MEASUREDAREA
        {
            get
            {
                return mEASUREDAREAField;
            }
            set
            {
                mEASUREDAREAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double PARCELLEGALAREA
        {
            get
            {
                return pARCELLEGALAREAField;
            }
            set
            {
                pARCELLEGALAREAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool PARCELLEGALAREASpecified
        {
            get
            {
                return pARCELLEGALAREAFieldSpecified;
            }
            set
            {
                pARCELLEGALAREAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        [DefaultValue(true)]
        public bool ISNEW
        {
            get
            {
                return iSNEWField;
            }
            set
            {
                iSNEWField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int FILEID
        {
            get
            {
                return fILEIDField;
            }
            set
            {
                fILEIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool FILEIDSpecified
        {
            get
            {
                return fILEIDFieldSpecified;
            }
            set
            {
                fILEIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double BUILDINGLEGALAREA
        {
            get
            {
                return bUILDINGLEGALAREAField;
            }
            set
            {
                bUILDINGLEGALAREAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool BUILDINGLEGALAREASpecified
        {
            get
            {
                return bUILDINGLEGALAREAFieldSpecified;
            }
            set
            {
                bUILDINGLEGALAREAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TAXVALUE
        {
            get
            {
                return tAXVALUEField;
            }
            set
            {
                tAXVALUEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TAXVALUESpecified
        {
            get
            {
                return tAXVALUEFieldSpecified;
            }
            set
            {
                tAXVALUEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NOTES
        {
            get
            {
                return nOTESField;
            }
            set
            {
                nOTESField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public bool ENCLOSED
        {
            get
            {
                return eNCLOSEDField;
            }
            set
            {
                eNCLOSEDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ENCLOSEDSpecified
        {
            get
            {
                return eNCLOSEDFieldSpecified;
            }
            set
            {
                eNCLOSEDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public bool COAREA
        {
            get
            {
                return cOAREAField;
            }
            set
            {
                cOAREAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool COAREASpecified
        {
            get
            {
                return cOAREAFieldSpecified;
            }
            set
            {
                cOAREAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string E2IDENTIFIER
        {
            get
            {
                return e2IDENTIFIERField;
            }
            set
            {
                e2IDENTIFIERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERCADNO
        {
            get
            {
                return pAPERCADNOField;
            }
            set
            {
                pAPERCADNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERLBNO
        {
            get
            {
                return pAPERLBNOField;
            }
            set
            {
                pAPERLBNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TOPONO
        {
            get
            {
                return tOPONOField;
            }
            set
            {
                tOPONOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CADGENNO
        {
            get
            {
                return cADGENNOField;
            }
            set
            {
                cADGENNOField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLParcel
    {

        private int pARCELIDField;

        private int lANDIDField;

        private bool lANDIDFieldSpecified;

        private int nUMBERField;

        private bool nUMBERFieldSpecified;

        private double mEASUREDAREAField;

        private bool mEASUREDAREAFieldSpecified;

        private string uSECATEGORYField;

        private bool iNTRAVILANField;

        private bool iNTRAVILANFieldSpecified;

        private double tAXVALUEField;

        private bool tAXVALUEFieldSpecified;

        private string tITLENOField;

        private string lANDPLOTNOField;

        private string pARCELNOField;

        private string nOTESField;

        private string e2IDENTIFIERField;

        private string pAPERCADNOField;

        private string pAPERLBNOField;

        private string tOPONOField;

        private string cADGENNOField;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int PARCELID
        {
            get
            {
                return pARCELIDField;
            }
            set
            {
                pARCELIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int LANDID
        {
            get
            {
                return lANDIDField;
            }
            set
            {
                lANDIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool LANDIDSpecified
        {
            get
            {
                return lANDIDFieldSpecified;
            }
            set
            {
                lANDIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int NUMBER
        {
            get
            {
                return nUMBERField;
            }
            set
            {
                nUMBERField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool NUMBERSpecified
        {
            get
            {
                return nUMBERFieldSpecified;
            }
            set
            {
                nUMBERFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double MEASUREDAREA
        {
            get
            {
                return mEASUREDAREAField;
            }
            set
            {
                mEASUREDAREAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MEASUREDAREASpecified
        {
            get
            {
                return mEASUREDAREAFieldSpecified;
            }
            set
            {
                mEASUREDAREAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string USECATEGORY
        {
            get
            {
                return uSECATEGORYField;
            }
            set
            {
                uSECATEGORYField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public bool INTRAVILAN
        {
            get
            {
                return iNTRAVILANField;
            }
            set
            {
                iNTRAVILANField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool INTRAVILANSpecified
        {
            get
            {
                return iNTRAVILANFieldSpecified;
            }
            set
            {
                iNTRAVILANFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double TAXVALUE
        {
            get
            {
                return tAXVALUEField;
            }
            set
            {
                tAXVALUEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TAXVALUESpecified
        {
            get
            {
                return tAXVALUEFieldSpecified;
            }
            set
            {
                tAXVALUEFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TITLENO
        {
            get
            {
                return tITLENOField;
            }
            set
            {
                tITLENOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string LANDPLOTNO
        {
            get
            {
                return lANDPLOTNOField;
            }
            set
            {
                lANDPLOTNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PARCELNO
        {
            get
            {
                return pARCELNOField;
            }
            set
            {
                pARCELNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NOTES
        {
            get
            {
                return nOTESField;
            }
            set
            {
                nOTESField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string E2IDENTIFIER
        {
            get
            {
                return e2IDENTIFIERField;
            }
            set
            {
                e2IDENTIFIERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERCADNO
        {
            get
            {
                return pAPERCADNOField;
            }
            set
            {
                pAPERCADNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PAPERLBNO
        {
            get
            {
                return pAPERLBNOField;
            }
            set
            {
                pAPERLBNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TOPONO
        {
            get
            {
                return tOPONOField;
            }
            set
            {
                tOPONOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CADGENNO
        {
            get
            {
                return cADGENNOField;
            }
            set
            {
                cADGENNOField = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLPerson
    {

        private int pERSONIDField;

        private int aDDRESSIDField;

        private bool aDDRESSIDFieldSpecified;

        private string fIRSTNAMEField;

        private bool iSPHYSICALField;

        private string lASTNAMEField;

        private bool dEFUNCTField;

        private bool dEFUNCTFieldSpecified;

        private bool iDENTIFIEDField;

        private bool iDENTIFIEDFieldSpecified;

        private string iDCODEField;

        private string pREVIOUSLASTNAMEField;

        private string fATHERINITIALField;

        private string cITIZENSHIPCOUNTRYField;

        private string iDCARDTYPEField;

        private string iDCARDSERIALNOField;

        private string iDCARDNUMBERField;

        private string nOTESField;

        private string pHONEField;

        private string eMAILField;

        private int fILEIDField;

        private bool fILEIDFieldSpecified;

        private int rEGISTRATIONIDField;

        private bool rEGISTRATIONIDFieldSpecified;

        public CGXMLPerson()
        {
            iSPHYSICALField = true;
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int PERSONID
        {
            get
            {
                return pERSONIDField;
            }
            set
            {
                pERSONIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int ADDRESSID
        {
            get
            {
                return aDDRESSIDField;
            }
            set
            {
                aDDRESSIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ADDRESSIDSpecified
        {
            get
            {
                return aDDRESSIDFieldSpecified;
            }
            set
            {
                aDDRESSIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string FIRSTNAME
        {
            get
            {
                return fIRSTNAMEField;
            }
            set
            {
                fIRSTNAMEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        [DefaultValue(true)]
        public bool ISPHYSICAL
        {
            get
            {
                return iSPHYSICALField;
            }
            set
            {
                iSPHYSICALField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string LASTNAME
        {
            get
            {
                return lASTNAMEField;
            }
            set
            {
                lASTNAMEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public bool DEFUNCT
        {
            get
            {
                return dEFUNCTField;
            }
            set
            {
                dEFUNCTField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool DEFUNCTSpecified
        {
            get
            {
                return dEFUNCTFieldSpecified;
            }
            set
            {
                dEFUNCTFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public bool IDENTIFIED
        {
            get
            {
                return iDENTIFIEDField;
            }
            set
            {
                iDENTIFIEDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool IDENTIFIEDSpecified
        {
            get
            {
                return iDENTIFIEDFieldSpecified;
            }
            set
            {
                iDENTIFIEDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IDCODE
        {
            get
            {
                return iDCODEField;
            }
            set
            {
                iDCODEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PREVIOUSLASTNAME
        {
            get
            {
                return pREVIOUSLASTNAMEField;
            }
            set
            {
                pREVIOUSLASTNAMEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string FATHERINITIAL
        {
            get
            {
                return fATHERINITIALField;
            }
            set
            {
                fATHERINITIALField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string CITIZENSHIPCOUNTRY
        {
            get
            {
                return cITIZENSHIPCOUNTRYField;
            }
            set
            {
                cITIZENSHIPCOUNTRYField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IDCARDTYPE
        {
            get
            {
                return iDCARDTYPEField;
            }
            set
            {
                iDCARDTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IDCARDSERIALNO
        {
            get
            {
                return iDCARDSERIALNOField;
            }
            set
            {
                iDCARDSERIALNOField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string IDCARDNUMBER
        {
            get
            {
                return iDCARDNUMBERField;
            }
            set
            {
                iDCARDNUMBERField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NOTES
        {
            get
            {
                return nOTESField;
            }
            set
            {
                nOTESField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PHONE
        {
            get
            {
                return pHONEField;
            }
            set
            {
                pHONEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string EMAIL
        {
            get
            {
                return eMAILField;
            }
            set
            {
                eMAILField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int FILEID
        {
            get
            {
                return fILEIDField;
            }
            set
            {
                fILEIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool FILEIDSpecified
        {
            get
            {
                return fILEIDFieldSpecified;
            }
            set
            {
                fILEIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int REGISTRATIONID
        {
            get
            {
                return rEGISTRATIONIDField;
            }
            set
            {
                rEGISTRATIONIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool REGISTRATIONIDSpecified
        {
            get
            {
                return rEGISTRATIONIDFieldSpecified;
            }
            set
            {
                rEGISTRATIONIDFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLPoints
    {

        private int pOINTIDField;

        private int iMMOVABLEIDField;

        private bool iMMOVABLEIDFieldSpecified;

        private int bUILDINGIDField;

        private bool bUILDINGIDFieldSpecified;

        private string noField;

        private double xField;

        private bool xFieldSpecified;

        private double yField;

        private bool yFieldSpecified;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int POINTID
        {
            get
            {
                return pOINTIDField;
            }
            set
            {
                pOINTIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int IMMOVABLEID
        {
            get
            {
                return iMMOVABLEIDField;
            }
            set
            {
                iMMOVABLEIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool IMMOVABLEIDSpecified
        {
            get
            {
                return iMMOVABLEIDFieldSpecified;
            }
            set
            {
                iMMOVABLEIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDINGID
        {
            get
            {
                return bUILDINGIDField;
            }
            set
            {
                bUILDINGIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool BUILDINGIDSpecified
        {
            get
            {
                return bUILDINGIDFieldSpecified;
            }
            set
            {
                bUILDINGIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NO
        {
            get
            {
                return noField;
            }
            set
            {
                noField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double X
        {
            get
            {
                return xField;
            }
            set
            {
                xField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool XSpecified
        {
            get
            {
                return xFieldSpecified;
            }
            set
            {
                xFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public double Y
        {
            get
            {
                return yField;
            }
            set
            {
                yField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool YSpecified
        {
            get
            {
                return yFieldSpecified;
            }
            set
            {
                yFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLRegistration
    {

        private int rEGISTRATIONIDField;

        private string rEGISTRATIONTYPEField;

        private string rIGHTTYPEField;

        private string rIGHTCOMMENTField;

        private string nOTESField;

        private int dEEDIDField;

        private string tITLEField;

        private string qUOTATYPEField;

        private string iNITIALQUOTAField;

        private string aCTUALQUOTAField;

        private string vALUECURRENCYField;

        private string vALUEAMOUNTField;

        private string cOMMENTSField;

        private int lBPARTNOField;

        private bool lBPARTNOFieldSpecified;

        private int pOSITIONField;

        private bool pOSITIONFieldSpecified;

        private int aPPNOField;

        private bool aPPNOFieldSpecified;

        private DateTime aPPDATEField;

        private bool aPPDATEFieldSpecified;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int REGISTRATIONID
        {
            get
            {
                return rEGISTRATIONIDField;
            }
            set
            {
                rEGISTRATIONIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string REGISTRATIONTYPE
        {
            get
            {
                return rEGISTRATIONTYPEField;
            }
            set
            {
                rEGISTRATIONTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string RIGHTTYPE
        {
            get
            {
                return rIGHTTYPEField;
            }
            set
            {
                rIGHTTYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string RIGHTCOMMENT
        {
            get
            {
                return rIGHTCOMMENTField;
            }
            set
            {
                rIGHTCOMMENTField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string NOTES
        {
            get
            {
                return nOTESField;
            }
            set
            {
                nOTESField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int DEEDID
        {
            get
            {
                return dEEDIDField;
            }
            set
            {
                dEEDIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string TITLE
        {
            get
            {
                return tITLEField;
            }
            set
            {
                tITLEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string QUOTATYPE
        {
            get
            {
                return qUOTATYPEField;
            }
            set
            {
                qUOTATYPEField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string INITIALQUOTA
        {
            get
            {
                return iNITIALQUOTAField;
            }
            set
            {
                iNITIALQUOTAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ACTUALQUOTA
        {
            get
            {
                return aCTUALQUOTAField;
            }
            set
            {
                aCTUALQUOTAField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string VALUECURRENCY
        {
            get
            {
                return vALUECURRENCYField;
            }
            set
            {
                vALUECURRENCYField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string VALUEAMOUNT
        {
            get
            {
                return vALUEAMOUNTField;
            }
            set
            {
                vALUEAMOUNTField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string COMMENTS
        {
            get
            {
                return cOMMENTSField;
            }
            set
            {
                cOMMENTSField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int LBPARTNO
        {
            get
            {
                return lBPARTNOField;
            }
            set
            {
                lBPARTNOField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool LBPARTNOSpecified
        {
            get
            {
                return lBPARTNOFieldSpecified;
            }
            set
            {
                lBPARTNOFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int POSITION
        {
            get
            {
                return pOSITIONField;
            }
            set
            {
                pOSITIONField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool POSITIONSpecified
        {
            get
            {
                return pOSITIONFieldSpecified;
            }
            set
            {
                pOSITIONFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int APPNO
        {
            get
            {
                return aPPNOField;
            }
            set
            {
                aPPNOField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool APPNOSpecified
        {
            get
            {
                return aPPNOFieldSpecified;
            }
            set
            {
                aPPNOFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public DateTime APPDATE
        {
            get
            {
                return aPPDATEField;
            }
            set
            {
                aPPDATEField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool APPDATESpecified
        {
            get
            {
                return aPPDATEFieldSpecified;
            }
            set
            {
                aPPDATEFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory(@"code")]
    [XmlType(AnonymousType = true)]
    public class CGXMLRegistrationXEntity
    {

        private int rEGISTRATIONXENTITYIDField;

        private int rEGISTRATIONIDField;

        private bool rEGISTRATIONIDFieldSpecified;

        private int lANDIDField;

        private bool lANDIDFieldSpecified;

        private int bUILDINGIDField;

        private bool bUILDINGIDFieldSpecified;

        private int iUIDField;

        private bool iUIDFieldSpecified;

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int REGISTRATIONXENTITYID
        {
            get
            {
                return rEGISTRATIONXENTITYIDField;
            }
            set
            {
                rEGISTRATIONXENTITYIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int REGISTRATIONID
        {
            get
            {
                return rEGISTRATIONIDField;
            }
            set
            {
                rEGISTRATIONIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool REGISTRATIONIDSpecified
        {
            get
            {
                return rEGISTRATIONIDFieldSpecified;
            }
            set
            {
                rEGISTRATIONIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int LANDID
        {
            get
            {
                return lANDIDField;
            }
            set
            {
                lANDIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool LANDIDSpecified
        {
            get
            {
                return lANDIDFieldSpecified;
            }
            set
            {
                lANDIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int BUILDINGID
        {
            get
            {
                return bUILDINGIDField;
            }
            set
            {
                bUILDINGIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool BUILDINGIDSpecified
        {
            get
            {
                return bUILDINGIDFieldSpecified;
            }
            set
            {
                bUILDINGIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int IUID
        {
            get
            {
                return iUIDField;
            }
            set
            {
                iUIDField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool IUIDSpecified
        {
            get
            {
                return iUIDFieldSpecified;
            }
            set
            {
                iUIDFieldSpecified = value;
            }
        }
    }

}

