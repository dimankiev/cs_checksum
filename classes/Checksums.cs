using System;
using System.IO;
using System.Security.Cryptography;

namespace WFCourseWork.classes {
    /// <summary>
    /// Represents file properties object.
    /// </summary>
    /// <field name="success">(bool) Represents IO operation success state</field>

    public class FileState {
        // IO success state
        public readonly bool success;
        // IO error exception/success message
        public readonly string message;
        // File path
        public readonly string path;
        // File name
        public readonly string name;
        // Formatted file size
        public readonly string size;
        // File size in bytes
        public readonly long length;
        /// <summary>
        /// Represents a method, which returns string-formatted, human-readable size
        /// </summary>
        /// <param name="fileSize">(long) File size in bytes</param>
        /// <returns></returns>
        private string formattedSize(long fileSize) {
            // IEC sizes array: KByte, MByte, GByte and TByte respectively
            double[] sizes = new double[] { 1024, Math.Pow(1024, 2), Math.Pow(1024, 3), Math.Pow(1024, 4) };
            // Format as size in bytes, if size < 1024^1
            if (fileSize < sizes[0]) return $"{fileSize} B";
            // Format in KBytes, if size < 1024^2
            if (fileSize < sizes[1]) return $"{fileSize / sizes[0]:F2} KB";
            // Format in MBytes, if size < 1024^3
            if (fileSize < sizes[2]) return $"{fileSize / sizes[1]:F2} MB";
            // Format in GBytes, if size < 1024^4
            if (fileSize < sizes[3]) return $"{fileSize / sizes[2]:F2} GB";
            // Format in TBytes, if size > 1024^4
            return $"{fileSize / sizes[3]:F2} TB";
        }
        /// <summary>
        /// Represents a constructor for FileState class
        /// </summary>
        /// <param name="filePath">(string) Absolute file path</param>
        public FileState(string filePath = "<??nofile??>") {
            if (filePath == "<??nofile??>") { 
                success = false;
                message = "No file chosen";
            }
            try {
                // Get file information and place it in the class fields
                FileInfo info = new FileInfo(filePath);
                path = info.FullName;
                name = $"{info.Name}";
                size = formattedSize(info.Length);
                length = info.Length;
                success = true;
                message = "Success!";
            } catch (Exception e) {
                // If there is some error occured - report, by saving Exception.Message
                success = false;
                message = e.Message;
            }
        }
    }
    static class Checksum {
        /// <summary>
        /// Represents a dynamic method, which detects and returns desired algorithm by it's shortname
        /// </summary>
        /// <param name="algoCode">(string) algorithm lowercase shortname</param>
        /// <returns>System.Security.Cryptography.XXX hash algorithm instance</returns>
        /// <example>
        /// <code>
        /// var algorithmInstance = getAlgo("sha512");
        /// </code>
        /// </example>
        private static dynamic getAlgo(string algoCode="md5") {
            // Filter by shortname
            if (algoCode == "sha1") return SHA1.Create();
            if (algoCode == "sha256") return SHA256.Create();
            if (algoCode == "sha512") return SHA512.Create();
            // If nothing matched - return MD5 instance
            return MD5.Create();
        }
        /// <summary>
        /// Represents a method to compute checksum by using desired alorithm
        /// </summary>
        /// <param name="stream">(FileStream) IO File read Stream</param>
        /// <param name="algoCode">(string) Algorithm shortname</param>
        /// <returns>(string[]) Array with computation results</returns>
        public static string[] Compute(FileStream stream, string algoCode) {
            // Results array, where first element - checksum, second - total time
            string[] results = { "hash", "totalSeconds" };
            // Time, when computation started
            DateTime start = DateTime.Now;
            // Do actions, using desired algorithm
            using (var algo = getAlgo(algoCode)) {
                // Compute checksum by desired algorithm
                byte[] checksum = algo.ComputeHash(stream);
                // Save checksum, converted to string
                results[0] = BitConverter.ToString(checksum).Replace("-", String.Empty).ToLower();
                // Save total seconds, spent on computation
                results[1] = (DateTime.Now - start).TotalSeconds.ToString();
            }
            // Return results of computation
            return results;
        }
    }
}