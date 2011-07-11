﻿using System.Collections.Generic;
using System.IO;
using System.Xml;
using Agdur.Abstractions;
using Agdur.Internals;

namespace Agdur
{
    public class XmlOutputStrategy : OutputStrategyBase
    {
        public override void Execute(TextWriter writer, IList<IMetric> metrics)
        {
            using (var xmlWriter = XmlWriter.Create(writer))
            {
                xmlWriter.WriteStartElement("benchmark");

                var visitor = new XmlOutputMetricVisitor(xmlWriter);
                Visit(visitor, metrics);

                xmlWriter.WriteEndElement();
            }
        }
    }
}