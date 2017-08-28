using ButterfliesXFPrism.Models;
using ButterfliesXFPrism.Services.ButterfliesService.Interfaces;
using System.Collections.Generic;

namespace ButterfliesXFPrism.Services.ButterfliesService
{
    public class ButterfliesService : IButterfliesService
    {
        private List<Butterfly> _butterfly;

        public ButterfliesService()
        {
            _butterfly = new List<Butterfly>
            {
                new Butterfly("1", "Butterfly1"),
                new Butterfly("2", "Butterfly2"),
                new Butterfly("3", "Butterfly3"),
                new Butterfly("4", "Butterfly4"),
                new Butterfly("5", "Butterfly5"),
                new Butterfly("6", "Butterfly6"),
                new Butterfly("7", "Butterfly7"),
                new Butterfly("8", "Butterfly8"),
                new Butterfly("9", "Butterfly9"),
                new Butterfly("10", "Butterfly10")
            };
        }

        public List<Butterfly> Load(int count)
        {
            return _butterfly;
        }
    }
}
