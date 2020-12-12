﻿using MobiFlight.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobiFlight.InputConfig
{
    public class EventIdInputAction : InputAction, ICloneable
    {
        const Int16 BaseOffset = 0x3110;
        const Int16 ParamOffset = 0x3114;

        public const String TYPE = "EventIdInputAction";
        public Int32 EventId;
        public Int32 Param;
        
        override public object Clone()
        {
            EventIdInputAction clone = new EventIdInputAction();
            clone.EventId = EventId;
            clone.Param = Param;

            return clone;
        }

        public override void ReadXml(System.Xml.XmlReader reader)
        {
            String eventId = reader["eventId"];
            String param = reader["param"];

            EventId = Int32.Parse(eventId);
            Param = Int32.Parse(param);
        }

        public override void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteAttributeString("type", getType());
            writer.WriteAttributeString("eventId", EventId.ToString());
            writer.WriteAttributeString("param", Param.ToString());
        }

        protected virtual String getType()
        {
            return TYPE;
        }

        public override void execute(FSUIPC.FSUIPCCacheInterface fsuipcCache, SimConnectMSFS.SimConnectCacheInterface simConnectCache, MobiFlightCacheInterface moduleCache)
        {
            fsuipcCache.setEventID(EventId, Param);
        }
    }
}
