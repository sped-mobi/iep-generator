using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace IEP.Generator.Core.Models
{

    [XmlRoot]
    public class IndividualizedEducationPlan
    {
        [XmlElement(typeof(StudentData))]
        public StudentData StudentData;

        [XmlArrayItem(typeof(AccommodationCategory))]
        public List<AccommodationCategory> AccommodationsList;
    }

    public class StudentData
    {
        [XmlElement]
        public string FirstName;

        [XmlElement]
        public string LastName;
    }

    public class AccommodationsList
    {
        [XmlElement(typeof(AccommodationCategory))]
        public List<AccommodationCategory> Categories;
    }

    public class AccommodationCategory
    {
        [XmlAttribute("name")]
        public string Name;

        [XmlElement(typeof(AccommodationItem))]
        public List<AccommodationItem> Items;
    }

    public class AccommodationItem
    {
        [XmlAttribute("ac")]
        [DefaultValue(false)]
        public bool AppliedCommunications;

        [XmlAttribute("acc")]
        [DefaultValue(false)]
        public bool AppliedCommunityCitizenship;

        [XmlAttribute("acs")]
        [DefaultValue(false)]
        public bool AppliedConsumerSkills;

        [XmlAttribute("aea")]
        [DefaultValue(false)]
        public bool AppliedEnvironmentalAwareness;

        [XmlAttribute("aph")]
        [DefaultValue(false)]
        public bool AppliedPersonalHealth;

        [XmlAttribute("ams")]
        [DefaultValue(false)]
        public bool AppliedMarketableSkills;

        [XmlAttribute("ppe")]
        [DefaultValue(false)]
        public bool PartnersInPhysicalEducation;

        [XmlAttribute("elec")]
        [DefaultValue(false)]
        public bool Elective;
    }
}
