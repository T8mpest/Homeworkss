namespace LogRead
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string logFilePath = "somefilepath.txt"; 
            string reportFilePath = "somereportpath.txt"; 

            try
            {
                List<LogEntry> logEntries = ReadLogFile(logFilePath);
                GenerateReport(logEntries, reportFilePath);
                Console.WriteLine("Log analysis and report generation completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static List<LogEntry> ReadLogFile(string filePath)
        {
            List<LogEntry> logEntries = new List<LogEntry>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime timestamp))
                    {
                        LogEntry logEntry = new LogEntry
                        {
                            Timestamp = timestamp,
                            LogLevel = parts[1],
                            Message = parts[2]
                        };
                        logEntries.Add(logEntry);
                    }
                    else
                    {
                        Console.WriteLine("Invalid log entry format: " + line);
                    }
                }
            }

            return logEntries;
        }

        static void GenerateReport(List<LogEntry> logEntries, string reportFilePath)
        {
            var logLevelCounts = logEntries.GroupBy(e => e.LogLevel)
                                            .Select(g => new { LogLevel = g.Key, Count = g.Count() })
                                            .OrderByDescending(g => g.Count);

            using (StreamWriter writer = new StreamWriter(reportFilePath))
            {
                writer.WriteLine("Log Analysis Report");
                writer.WriteLine("--------------------");
                writer.WriteLine("Total log entries: " + logEntries.Count);
                writer.WriteLine();

                writer.WriteLine("Log levels and their counts:");
                foreach (var item in logLevelCounts)
                {
                    writer.WriteLine($"{item.LogLevel}: {item.Count}");
                }
            }
        }
    }
}