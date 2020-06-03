namespace PartnerArchiver
{
    public interface IPlugin
    {
        void Create(string path);

        void Read(string zipPath);

        string ToString();
        
        object Clone();
    }
}
