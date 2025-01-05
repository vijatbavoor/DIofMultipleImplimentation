public interface IFisEndpointConfig
{
    string BaseUrl {get; set;}
    IEnumerable<EndPoints> EndPoints {get; set;}
}