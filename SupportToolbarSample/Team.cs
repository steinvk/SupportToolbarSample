using System;
namespace SupportToolbarSample
{
    public class Team
    {
        public string Name { get; set; }
        public string Home { get; set; }
        public string ChestURL { get; set; }

        public Team()
        {
            
        }

		public override string ToString()
		{
            return Name;
		}
	}
}
