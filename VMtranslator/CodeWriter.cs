using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMtranslator
{
    partial class CodeWriter
    {
        public CodeWriter(StreamWriter file) { 
            //출력 파일/스트림을 열어서 기록할 준비를 한다.
            
        }
        public void setFileName(string filename) { 
            //코드 작성기에게 새로운 VM 파일 번역이 시작되었음을 알린다.
        
        }
        public void writerArithmetic(string command) {
            //주어진 산술 명령을 번역한 어셈블리 코드를 기록한다.
            /* 어셈블리어 연산 
                { "0","0101010" },  { "1","0111111" },{ "-1","0111010" },{ "D","0001100" },{ "A","0110000" },{ "!D","0001101" },
                { "!A" ,"0110001" }, { "-D" ,"0001111" }, { "-A" ,"0110011" }, { "D+1" ,"0011111" }, { "A+1" ,"0110111" }, { "D-1" ,"0001110" },
                { "A-1" ,"0110010" }, { "D+A" ,"0000010" }, { "D-A" ,"0010011" }, { "A-D" ,"0000111" }, { "D&A" ,"0000000" }, { "D|A" ,"0010101" },
                { "M" ,"1110000" }, { "!M" ,"1110001" }, { "-M" ,"1110011" }, { "M+1" ,"1110111" }, { "M-1" ,"1110010" }, { "D+M" ,"1000010" },
                { "D-M" ,"1010011" }, { "M-D" ,"1000111" }, { "D&M" ,"1000000" }, { "D|M" ,"1010101" }
             */

        }
        public void writePushPop(int commandNum, string segmentName, int indexNum) { 
            //주어진 commandNum을 번역한 어셈블리 코드를 기록한다. 여기서 command는 C_PUSH나 C_POP이다.
        
        }
        public void closeStream() { 
            //출력파일을 닫는다.
        }
    }
}
