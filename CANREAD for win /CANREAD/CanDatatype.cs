/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace lcmtypes
{
    public sealed class CanDatatype : LCM.LCM.LCMEncodable
    {
        public double wheelspeedFL;
        public double wheelspeedFR;
        public double wheelspeedBL;
        public double wheelspeedBR;
        public double carspeed;
        public double steeringAngle;
        public double steeringAngleSpeed;
 
        public CanDatatype()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x4b6124cc531d8c06L;
 
        static CanDatatype()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("lcmtypes.CanDatatype"))
                return 0L;
 
            classes.Add("lcmtypes.CanDatatype");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            outs.Write(this.wheelspeedFL); 
 
            outs.Write(this.wheelspeedFR); 
 
            outs.Write(this.wheelspeedBL); 
 
            outs.Write(this.wheelspeedBR); 
 
            outs.Write(this.carspeed); 
 
            outs.Write(this.steeringAngle); 
 
            outs.Write(this.steeringAngleSpeed); 
 
        }
 
        public CanDatatype(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public CanDatatype(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static lcmtypes.CanDatatype _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            lcmtypes.CanDatatype o = new lcmtypes.CanDatatype();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            this.wheelspeedFL = ins.ReadDouble();
 
            this.wheelspeedFR = ins.ReadDouble();
 
            this.wheelspeedBL = ins.ReadDouble();
 
            this.wheelspeedBR = ins.ReadDouble();
 
            this.carspeed = ins.ReadDouble();
 
            this.steeringAngle = ins.ReadDouble();
 
            this.steeringAngleSpeed = ins.ReadDouble();
 
        }
 
        public lcmtypes.CanDatatype Copy()
        {
            lcmtypes.CanDatatype outobj = new lcmtypes.CanDatatype();
            outobj.wheelspeedFL = this.wheelspeedFL;
 
            outobj.wheelspeedFR = this.wheelspeedFR;
 
            outobj.wheelspeedBL = this.wheelspeedBL;
 
            outobj.wheelspeedBR = this.wheelspeedBR;
 
            outobj.carspeed = this.carspeed;
 
            outobj.steeringAngle = this.steeringAngle;
 
            outobj.steeringAngleSpeed = this.steeringAngleSpeed;
 
            return outobj;
        }
    }
}

