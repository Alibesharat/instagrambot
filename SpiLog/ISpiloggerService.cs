using System.Threading.Tasks;

namespace SpiLog
{
    public interface ISpiloggerService
    {

        Task CreateLogAsync(ReportFolder reportFolder, string filename);

        void Write(string Message, string Value = null);

        string GetLogsExistInMemmory();
    }
}
