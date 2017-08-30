using ButterfliesXFPrism.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ButterfliesXFPrism.Services.ButterfliesService
{
    public class ButterfliesService : IButterfliesService
    {
        private List<Butterfly> _butterflyList;

        public ButterfliesService()
        {
            _butterflyList = new List<Butterfly>
            {
                new Butterfly("1", "Butterfly1", "Description about Butterfly1","butterfly1.jpg"),
                new Butterfly("2", "Butterfly2", "Description about Butterfly2","butterfly2.jpg"),
                new Butterfly("3", "Butterfly3", "Description about Butterfly3","butterfly3.jpg"),
                new Butterfly("4", "Butterfly4", "Description about Butterfly4","butterfly4.jpg"),
                new Butterfly("5", "Butterfly5", "Description about Butterfly5","butterfly5.jpg"),
                new Butterfly("6", "Butterfly6", "Description about Butterfly6","butterfly6.jpg"),
                new Butterfly("7", "Butterfly7", "Description about Butterfly7","butterfly1.jpg"),
                new Butterfly("8", "Butterfly8", "Description about Butterfly8","butterfly2.jpg"),
                new Butterfly("9", "Butterfly9", "Description about Butterfly9","butterfly3.jpg"),
                new Butterfly("10", "Butterfly10", "Description about Butterfly10","butterfly4.jpg"),
                new Butterfly("11", "Butterfly11", "Description about Butterfly11","butterfly5.jpg"),
                new Butterfly("12", "Butterfly12", "Description about Butterfly12","butterfly6.jpg"),
                new Butterfly("13", "Butterfly13", "Description about Butterfly13","butterfly1.jpg"),
                new Butterfly("14", "Butterfly14", "Description about Butterfly14","butterfly2.jpg"),
                new Butterfly("15", "Butterfly15", "Description about Butterfly15","butterfly3.jpg"),
                new Butterfly("16", "Butterfly16", "Description about Butterfly16","butterfly4.jpg"),
                new Butterfly("17", "Butterfly17", "Description about Butterfly17","butterfly5.jpg"),
                new Butterfly("18", "Butterfly18", "Description about Butterfly18","butterfly6.jpg"),
                new Butterfly("19", "Butterfly19", "Description about Butterfly19","butterfly1.jpg"),
                new Butterfly("20", "Butterfly20", "Description about Butterfly20","butterfly2.jpg"),
            };
        }

        public async Task<List<Butterfly>> Load(int count, int offset = 0)
        {
            var countSelect = Math.Min(count,_butterflyList.Count - offset);
            return _butterflyList.GetRange(offset, countSelect);
        }
    }
}
