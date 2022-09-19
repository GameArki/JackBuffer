using UnityEngine;
using JackBuffer;

namespace JackBuffer.Editor {

    public class JackBufferGeneratorSampleTool {
#if JACK_FRAME_DEV
        [UnityEditor.MenuItem("JackFrame/Sample/JackBuffer/Gen")]
#endif
        public static void Gen() {

            JackBufferGenerator.GenModel(Application.dataPath + "/com.jackwithtea.jackframe/JackBuffer/Tests/SampleTest/Messages");

        }

    }

}