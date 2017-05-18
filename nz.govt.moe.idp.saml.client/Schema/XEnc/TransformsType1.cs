using System;
using System.Xml.Serialization;
using nz.govt.moe.idp.saml.client.Schema.XmlDSig;

namespace nz.govt.moe.idp.saml.client.Schema.XEnc
{
    /// <summary>
    /// The Transforms type
    /// </summary>
    [Serializable]
    [XmlType(TypeName="TransformsType", Namespace=Saml20Constants.XENC)]
    public class TransformsType1
    {
        /// <summary>
        /// The XML Element name of this class
        /// </summary>
        public const string ELEMENT_NAME = "TransformsType";

        private Transform[] transformField;


        /// <summary>
        /// Gets or sets the transform.
        /// </summary>
        /// <value>The transform.</value>
        [XmlElement("Transform", Namespace=Saml20Constants.XMLDSIG)]
        public Transform[] Transform
        {
            get { return transformField; }
            set { transformField = value; }
        }
    }
}