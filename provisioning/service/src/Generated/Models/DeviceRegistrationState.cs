// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Devices.Provisioning.Service.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Device registration state.
    /// </summary>
    public partial class DeviceRegistrationState
    {
        /// <summary>
        /// Initializes a new instance of the DeviceRegistrationState class.
        /// </summary>
        public DeviceRegistrationState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceRegistrationState class.
        /// </summary>
        /// <param name="registrationId">The registration ID is alphanumeric,
        /// lowercase, and may contain hyphens.</param>
        /// <param name="createdDateTimeUtc">Registration create date time (in
        /// UTC).</param>
        /// <param name="assignedHub">Assigned Azure IoT Hub.</param>
        /// <param name="deviceId">Device ID.</param>
        /// <param name="status">Enrollment status. Possible values include:
        /// 'unassigned', 'assigning', 'assigned', 'failed', 'disabled'</param>
        /// <param name="substatus">Substatus for 'Assigned' devices. Possible
        /// values include - 'initialAssignment': Device has been assigned to
        /// an IoT hub for the first time, 'deviceDataMigrated': Device has
        /// been assigned to a different IoT hub and its device data was
        /// migrated from the previously assigned IoT hub. Device data was
        /// removed from the previously assigned IoT hub, 'deviceDataReset':
        /// Device has been assigned to a different IoT hub and its device data
        /// was populated from the initial state stored in the enrollment.
        /// Device data was removed from the previously assigned IoT hub.
        /// Possible values include: 'initialAssignment', 'deviceDataMigrated',
        /// 'deviceDataReset'</param>
        /// <param name="errorCode">Error code.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <param name="lastUpdatedDateTimeUtc">Last updated date time (in
        /// UTC).</param>
        /// <param name="etag">The entity tag associated with the
        /// resource.</param>
        public DeviceRegistrationState(string registrationId = default(string), System.DateTime? createdDateTimeUtc = default(System.DateTime?), string assignedHub = default(string), string deviceId = default(string), string status = default(string), string substatus = default(string), int? errorCode = default(int?), string errorMessage = default(string), System.DateTime? lastUpdatedDateTimeUtc = default(System.DateTime?), string etag = default(string))
        {
            RegistrationId = registrationId;
            CreatedDateTimeUtc = createdDateTimeUtc;
            AssignedHub = assignedHub;
            DeviceId = deviceId;
            Status = status;
            Substatus = substatus;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            LastUpdatedDateTimeUtc = lastUpdatedDateTimeUtc;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the registration ID is alphanumeric, lowercase, and may
        /// contain hyphens.
        /// </summary>
        [JsonProperty(PropertyName = "registrationId")]
        public string RegistrationId { get; private set; }

        /// <summary>
        /// Gets registration create date time (in UTC).
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTimeUtc")]
        public System.DateTime? CreatedDateTimeUtc { get; private set; }

        /// <summary>
        /// Gets assigned Azure IoT Hub.
        /// </summary>
        [JsonProperty(PropertyName = "assignedHub")]
        public string AssignedHub { get; private set; }

        /// <summary>
        /// Gets device ID.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; private set; }

        /// <summary>
        /// Gets enrollment status. Possible values include: 'unassigned',
        /// 'assigning', 'assigned', 'failed', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets substatus for 'Assigned' devices. Possible values include -
        /// 'initialAssignment': Device has been assigned to an IoT hub for the
        /// first time, 'deviceDataMigrated': Device has been assigned to a
        /// different IoT hub and its device data was migrated from the
        /// previously assigned IoT hub. Device data was removed from the
        /// previously assigned IoT hub, 'deviceDataReset':  Device has been
        /// assigned to a different IoT hub and its device data was populated
        /// from the initial state stored in the enrollment. Device data was
        /// removed from the previously assigned IoT hub. Possible values
        /// include: 'initialAssignment', 'deviceDataMigrated',
        /// 'deviceDataReset'
        /// </summary>
        [JsonProperty(PropertyName = "substatus")]
        public string Substatus { get; private set; }

        /// <summary>
        /// Gets error code.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; private set; }

        /// <summary>
        /// Gets error message.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets last updated date time (in UTC).
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedDateTimeUtc")]
        public System.DateTime? LastUpdatedDateTimeUtc { get; private set; }

        /// <summary>
        /// Gets the entity tag associated with the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}