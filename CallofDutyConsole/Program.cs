using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CallofDutyConsole
{
    public class Program
    {
        static void Main(string[] args)
        { 
            var response = WarZoneStats.CallOfDuty();

            var player = WarZoneStats.BRCODParse(response);

            Console.WriteLine($"Wins: {player.Wins}, Top 25 Finishes: {player.TopTwentyFive}, Top 10 Finishes: {player.TopTen}, Top 5 Finishes: {player.TopFive}");
            Console.WriteLine($"Kills: {player.Kills}, Deaths: {player.Deaths}, KD Ratio: {player.KDRatio}");
            Console.WriteLine($"Overall Score: {player.Score}, Score Per Minute: {player.ScorePerMinute}");
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
