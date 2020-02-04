using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;

namespace MHW_Editor {
    public class EncryptionHelper {
        public const string PL_PARAM_KEY = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";
        public const string SAVE_FILE_KEY = "xieZjoe#P2134-3zmaghgpqoe0z8$3azeq";

        public static void DecryptFiles() {
            const string fileRoot = @"V:\MHW\IB\chunk_combined\common\pl";
            Decrypt($"{fileRoot}\\pl_param.plp", $"{fileRoot}\\pl_param.decrypted.plp");
            Decrypt($"{fileRoot}\\pl_skill_param.plsp", $"{fileRoot}\\pl_skill_param.decrypted.plsp");
        }

        public static void Decrypt(string inFile, string outFile) {
            var cipher = new BufferedBlockCipher(new BlowfishEngine());
            cipher.Init(false, new KeyParameter(Encoding.UTF8.GetBytes(PL_PARAM_KEY)));

            var out1 = File.ReadAllBytes(inFile);
            out1 = BSwap(out1);

            var out2 = new byte[cipher.GetOutputSize(out1.Length)];

            var len2 = cipher.ProcessBytes(out1, 0, out1.Length, out2, 0);
            cipher.DoFinal(out2, len2);

            File.WriteAllBytes(outFile, out2);
        }

        public static byte[] BSwap(byte[] data) {
            var result = new byte[data.Length];

            for (var i = 0; i < data.Length; i += 4) {
                result[i] = data[i + 3];
                result[i + 1] = data[i + 2];
                result[i + 2] = data[i + 1];
                result[i + 3] = data[i];
            }

            return result;
        }
    }
}