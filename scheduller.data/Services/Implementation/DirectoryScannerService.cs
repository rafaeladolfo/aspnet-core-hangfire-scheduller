using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduller.data.Services.Implementation
{
    public class DirectoryScannerService
    {
        public void ScanDeactivatedAccounts()
        {
            string path = "LDAP://dc=example,dc=local";
            DirectoryEntry directoryRoot = new DirectoryEntry(path);
            DirectorySearcher searcher = new DirectorySearcher(directoryRoot,
                "(&(objectClass=User)(objectCategory=Person))");
            SearchResultCollection results = searcher.FindAll();
            foreach (SearchResult result in results)
            {
                DirectoryEntry de = result.GetDirectoryEntry();
                if (IsActive(de))
                    DisableDependantAccounts(de.Username);

            }
        }

        private bool IsActive(DirectoryEntry de)
        {
            if (de.NativeGuid == null) return false;
            int flags = (int)de.Properties["userAccountControl"].Value;

            return !Convert.ToBoolean(flags & 0x0002);
        }

        private void DisableDependantAccounts(string userName)
        {

        }
    }
}
