using System.Text.Json.Serialization;

namespace SchoolDirectoryApp.Models;

public class School
{
    [JsonPropertyName("schoolId")]
    public int SchoolId { get; set; }

    [JsonPropertyName("schoolName")]
    public string SchoolName { get; set; } = string.Empty;

    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    [JsonPropertyName("phoneNo")]
    public string PhoneNo { get; set; } = string.Empty;

    [JsonPropertyName("emailAddress")]
    public string EmailAddress { get; set; } = string.Empty;

    [JsonPropertyName("proprietorFullName")]
    public string ProprietorFullName { get; set; } = string.Empty;

    [JsonPropertyName("headFullName")]
    public string HeadFullName { get; set; } = string.Empty;
}