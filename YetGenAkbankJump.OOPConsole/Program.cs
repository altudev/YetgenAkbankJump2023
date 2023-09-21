using System.Text.Json;
using YetGenAkbankJump.OOPConsole.Entities;

var filePath = "C:\\Users\\alper\\Desktop\\AccessControlLogs.txt";

var textFile = File.ReadAllText(filePath);

var splittedLines = textFile.Split("\r\n",StringSplitOptions.RemoveEmptyEntries);

// 7---FRNM3121049B---FP---2023-08-09T10:15:32+00:00


List<AccessControlLog> logs = new();

foreach (var splittedLine in splittedLines)
{
  var values =  splittedLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

  var accessControlLog = new AccessControlLog()
  {
      Id = Guid.NewGuid(),
      CreatedOn = DateTimeOffset.Now,
      PersonId = Convert.ToInt64(values[0]),
      DeviceSerialNo = values[1],
      AccessType = AccessControlLog.ConvertStringToAccessType(values[2]),
      LogTime = Convert.ToDateTime(values[3])
  };

  logs.Add(accessControlLog);
}

File.WriteAllText("C:\\Users\\alper\\Desktop\\AccessControlLogsJson.txt",JsonSerializer.Serialize(logs));

Console.WriteLine("The operation was successfully completed.");

Console.ReadLine();
