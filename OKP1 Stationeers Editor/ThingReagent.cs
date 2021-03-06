﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OKP1_Stationeers_Editor
{
    public class ThingReagent : ThingManager
    {
        public Single Quantity
        {
            get
            {
                return Single.Parse(XML.Element("Quantity").Value);
            }
            set
            {
                XML.Element("Quantity").SetValue(value);
            }
        }

        public string TypeName
        {

            get
            {
                return XML.Element("TypeName").Value;
            }
            set
            {
                XML.Element("TypeName").SetValue(value);
                _name = value;
            }
        }

        public ThingReagent Self => this;
        public ThingReagent()
        {
            _typeOf = ThingType.Reagent;
        }

        public ThingReagent(XElement thing) : this()
        {

            _xmlThing = thing;
            // get name from TypeName
            _name = thing.Element("TypeName").Value;
        }
    }
}
