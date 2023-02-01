using System;
using System.IO;
using System.Threading.Tasks;
using Android.App;
using Java.Lang;
using Java.IO;

namespace testingcam.Droid
{
	public class FFmpegWrapper
	{
        public async Task<string> Execute(params string[] command)
        {
            var ffmpegBin = Path.Combine(Application.Context.FilesDir.AbsolutePath, "ffmpeg");
            var output = new StringBuilder();

            try
            {
                var process = new ProcessBuilder(command).Start();

                var stdout = new BufferedReader(new InputStreamReader(process.InputStream));
                var line = "";
                while ((line = stdout.ReadLine()) != null)
                {
                    output.Append(line).Append(System.Environment.NewLine);
                }
                stdout.Close();

                process.WaitFor();
            }
            catch (Java.Lang.InterruptedException e)
            {
                output.Append(e.Message);
            }
            catch (Java.IO.IOException e)
            {
                output.Append(e.Message);
            }

            return output.ToString();
        }
    }
}

