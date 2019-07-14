using System.Collections.Generic;
using System.Threading.Tasks;

namespace NasaAPIService
{
    public interface IRoverApi
    {
        string GetImagesJson(FormattedDate formattedDate);
        NasaRoverImages GetImages(FormattedDate formattedDate);
        string SaveRoverImage(FormattedDate formattedDate, Photo roverImage);
        Task<List<string>> SaveRoverImages(FormattedDate formattedDate);
    }
}