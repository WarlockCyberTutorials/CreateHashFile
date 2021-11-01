using CreateHashFile.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class CreateHashFile
    {
        public static string ObterHashDoArquivo(TipoDeHash.Hash pTipoHash, string pCaminhoDoArquivo)
        {
            var stringBuilder = new StringBuilder();

            using (var file = new FileStream(pCaminhoDoArquivo, FileMode.Open))
            {
                HashAlgorithm hash;

                if (pTipoHash == TipoDeHash.Hash.Md5)
                {
                    hash = new MD5CryptoServiceProvider();
                }
                else
                {
                    hash = new SHA1CryptoServiceProvider();
                }

                if (hash != null)
                {
                    var retVal = hash.ComputeHash(file);
                    for (int i = 0; i < retVal.Length; i++)
                    {
                        stringBuilder.Append(retVal[i].ToString("x2"));
                    }
                }

                hash.Dispose();
            }

            return stringBuilder.ToString();
        }
    }
}
