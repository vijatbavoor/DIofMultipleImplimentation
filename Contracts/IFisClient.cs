public interface IFisClient
{
    public string PaymentInstrument { get; }
    string SubmitToFis(string messageType);
}