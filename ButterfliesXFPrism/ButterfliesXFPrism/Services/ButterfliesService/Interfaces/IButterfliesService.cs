using ButterfliesXFPrism.Models;
using System.Collections.Generic;

namespace ButterfliesXFPrism.Services.ButterfliesService.Interfaces
{
    public interface IButterfliesService
    {
        List<Butterfly> Load(int count);
    }
}
