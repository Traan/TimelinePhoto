using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimelinePhoto.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new TimelinePhoto.Service.Repositories.DropboxRepository("mfjgzikmjktt5hg", "gprf9vz2ekogyoh", "6vmrvkbjsn60nd8", "wzytquawcdatss2");
            var entries = repo.GetEntries();
        }
    }
}
