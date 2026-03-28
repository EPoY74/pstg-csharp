namespace Pstg.Domain.Modbus;

public enum ModbusFunctionCode : byte
{
    ReadHoldingRegisters = 3,
    ReadInputRegister = 4
}