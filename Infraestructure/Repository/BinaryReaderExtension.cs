using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public static class BinaryReaderExtension
    {
        //TODO avoid T and try to replace TypeCode by type
        public static object GetValue<T>(this BinaryReader br, TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Boolean: { return br.ReadBoolean(); }
                case TypeCode.Byte: { return br.ReadByte(); }
                case TypeCode.Char: { return br.ReadChar(); }
                case TypeCode.Decimal: { return br.ReadDecimal(); }
                case TypeCode.Double: { return br.ReadDouble(); }
                case TypeCode.Single: { return br.ReadSingle(); }
                case TypeCode.Int16: { return br.ReadInt16(); }
                case TypeCode.Int32: { return br.ReadInt32(); }
                case TypeCode.Int64: { return br.ReadUInt64(); }
                case TypeCode.String: { return br.ReadString(); }
                default: { return br.Read(); }
            }
        }
    }
}
