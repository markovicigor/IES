﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTN.Common;
namespace FTN.Services.NetworkModelService.DataModel
{
    public class BasicIntervalSchedule : IdentifiedObject
    {

        public BasicIntervalSchedule(long globalId) : base(globalId)
        {

        }
      
        private DateTime startTime;
        private UnitMultiplier? value1Multiplier;
        private UnitSymbol? value1Unit;
        private UnitMultiplier? value2Multiplier;
        private UnitSymbol? value2Unit;

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public UnitMultiplier? Value1Multiplier { get => value1Multiplier; set => value1Multiplier = value; }
        public UnitSymbol? Value1Unit { get => value1Unit; set => value1Unit = value; }
        public UnitMultiplier? Value2Multiplier { get => value2Multiplier; set => value2Multiplier = value; }
        public UnitSymbol? Value2Unit { get => value2Unit; set => value2Unit = value; }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                BasicIntervalSchedule x = (BasicIntervalSchedule)obj;
                return (x.startTime == this.startTime && x.value1Multiplier == this.value1Multiplier && x.value1Unit == this.value1Unit && x.value2Multiplier == this.value2Multiplier && x.value2Unit == this.value2Unit);
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #region IAccess
        public override bool HasProperty(ModelCode prop)
        {
            switch (prop)
            {
                case ModelCode.BASICINTERVALSCHEDULE_STARTTIME:
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1MULTIPLIER:
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1UNIT:
                case ModelCode.BASICINTERVALSCHEDULE_VALUE2MULTIPLIER:
                case ModelCode.BASICINTERVALSCHEDULE_VALUE2UNIT:
                    return true;
                default:
                    return base.HasProperty(prop);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {

                case ModelCode.BASICINTERVALSCHEDULE_STARTTIME:
                    property.SetValue(startTime);
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1MULTIPLIER:
                    property.SetValue((short)value1Multiplier);
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1UNIT:
                    property.SetValue((short)value1Unit);
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE2MULTIPLIER:
                    property.SetValue((short)value2Multiplier);
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE2UNIT:
                    property.SetValue((short)value2Unit);
                    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.BASICINTERVALSCHEDULE_STARTTIME:
                    startTime = property.AsDateTime();
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1MULTIPLIER:
                    value1Multiplier = (UnitMultiplier)property.AsEnum();
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE1UNIT:
                    value1Unit = (UnitSymbol)property.AsEnum();
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE2MULTIPLIER:
                    value2Multiplier = (UnitMultiplier)property.AsEnum();
                    break;
                case ModelCode.BASICINTERVALSCHEDULE_VALUE2UNIT:
                    value2Unit = (UnitSymbol)property.AsEnum();
                    break;
                default:
                    base.SetProperty(property);
                    break;
            }
            #endregion IAccess
        }
    }
}
