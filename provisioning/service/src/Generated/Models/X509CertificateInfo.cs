// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Service.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// X509 certificate info.
    /// </summary>
    public partial class X509CertificateInfo
    {
        /// <summary>
        /// Initializes a new instance of the X509CertificateInfo class.
        /// </summary>
        public X509CertificateInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X509CertificateInfo class.
        /// </summary>
        public X509CertificateInfo(string subjectName, string sha1Thumbprint, string sha256Thumbprint, string issuerName, System.DateTime notBeforeUtc, System.DateTime notAfterUtc, string serialNumber, int version)
        {
            SubjectName = subjectName;
            Sha1Thumbprint = sha1Thumbprint;
            Sha256Thumbprint = sha256Thumbprint;
            IssuerName = issuerName;
            NotBeforeUtc = notBeforeUtc;
            NotAfterUtc = notAfterUtc;
            SerialNumber = serialNumber;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectName")]
        public string SubjectName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sha1Thumbprint")]
        public string Sha1Thumbprint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sha256Thumbprint")]
        public string Sha256Thumbprint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuerName")]
        public string IssuerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notBeforeUtc")]
        public System.DateTime NotBeforeUtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notAfterUtc")]
        public System.DateTime NotAfterUtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubjectName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubjectName");
            }
            if (Sha1Thumbprint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sha1Thumbprint");
            }
            if (Sha256Thumbprint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sha256Thumbprint");
            }
            if (IssuerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IssuerName");
            }
            if (SerialNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SerialNumber");
            }
        }
    }
}