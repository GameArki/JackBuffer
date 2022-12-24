using UnityEngine;
using GameArki.BufferIOExtra;

namespace GameArki.BufferIOExtra.Editor {

    public class BufferIOExtraGeneratorSampleTool {
#if GAMEARKI_DEV
        [UnityEditor.MenuItem("GameArki/Sample/BufferIOExtra/Gen")]
#endif
        public static void Gen() {

            BufferExtraGenerator.GenModel(Application.dataPath + "/com.gamearki.bufferioextra/Tests/SampleTest/Messages");

        }

    }

}