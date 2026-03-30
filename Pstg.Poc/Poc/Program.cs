using FluentModbus;


var unitId = 1;
var startingAdress = 0;
var count = 2;



using (var client = new ModbusTcpClient())
{
   try
    {
        client.Connect("127.0.0.1:1502", ModbusEndianness.BigEndian); // LittleEndian        
    }
    catch(Exception ex)
    {
        Console.WriteLine("Exeption: " + ex.Message);
        throw ex;
    }

    while (true)
        {
            var registers = client.ReadHoldingRegisters<ushort>(unitId, startingAdress, count);
            Console.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": ");
            Console.WriteLine(registers[0]);
            Thread.Sleep(200);
        } 
}
