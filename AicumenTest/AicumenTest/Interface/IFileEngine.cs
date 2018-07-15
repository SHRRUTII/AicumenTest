using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AicumenTest.Interface
{
    public interface IFileEngine
    {
        Task WriteTextAsync(string storedText, string text);
        Task<string> ReadTextAsync(string storedText);
        Task<IEnumerable<string>> GetFilesAsync();
    }
}
