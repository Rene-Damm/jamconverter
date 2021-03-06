﻿using System;
using NUnit.Framework;

namespace jamconverter.Tests
{
    [TestFixture]
    class JamRunnerTests
    {
        [Test]
        public void CanRunJamProgram()
        {
            var program =
@"
local a = harry sally ;
Echo $(a)$(a) ;
";
            var jamRunner = new JamRunner();
            var output = jamRunner.Run(new [] { new SourceFileDescription() { Contents = program, FileName = "Jamfile.jam"}});
            CollectionAssert.AreEqual(new[] {"harryharry harrysally sallyharry sallysally "}, output);
        }



		[Test]
    //    [Ignore("PlayGround")]
        public void PlayGround()
        {
            var program =
@"

hallo = vier vijf ;
b = ja dus ;

Echo $(hallo)john$(b) ;

";

            var jamRunner = new JamRunner();
			var output = jamRunner.Run(new[] { new SourceFileDescription() { Contents = program, FileName = "Jamfile.jam" } });
			foreach (var line in output)
                Console.WriteLine(line);

            
        }
    }
}
