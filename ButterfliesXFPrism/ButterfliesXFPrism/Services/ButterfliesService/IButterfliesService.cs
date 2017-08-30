using ButterfliesXFPrism.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ButterfliesXFPrism.Services.ButterfliesService
{
    public interface IButterfliesService
    {
        Task<List<Butterfly>> Load(int count, int offset = 0);
    }
}
