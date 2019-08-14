using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Common
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-8-14 17:34:17
    //  文件名：QRCodeHelper
    //  版本：V1.0.1  
    //  说明： qrcocde 生成二维码
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class QRCodeHelper
    {
        public static QRCodeHelper CreateQRCodeHelper() {
            QRCodeHelper _QRCodeHelper = new QRCodeHelper();
            return _QRCodeHelper;
        }
        
        // <summary>
        /// 将string 转为二维码
        /// </summary>
        /// <param name="strContent">待编码的字符</param>
        /// <param name="ms">图片输出流</param>
        public bool CreateQRCode(string strContent, MemoryStream ms)
        {
            ErrorCorrectionLevel Ecl = ErrorCorrectionLevel.M; //误差校正水平 
            string Content = strContent;//待编码内容
            QuietZoneModules QuietZones = QuietZoneModules.Two;  //空白区域 
            int ModuleSize = 12;//大小
            var encoder = new QrEncoder(Ecl);
            QrCode qr;
            if (encoder.TryEncode(Content, out qr))//对内容进行编码，并保存生成的矩阵
            {

                var render = new GraphicsRenderer(new FixedModuleSize(ModuleSize, QuietZones));
                render.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
            }
            else
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 将字符串转化为二维码图片 base64str
        /// </summary>
        /// <param name="strContent">转化的字符串</param>
        /// <returns></returns>
        public string CreateQRCode(string strContent)
        {
            string content=string.Empty;
            using (var ms = new MemoryStream())
            {
                if (CreateQRCode(strContent, ms))
                {
                    content = Convert.ToBase64String(ms.ToArray());
                }
            }
            return content;
        }

        /// <summary>
        /// 将文字添加到对应的图片中间
        /// </summary>
        /// <param name="msc">输入流</param>
        /// <param name="ms">图片流</param>
        /// <param name="text">输入文字</param>
        public  void AddTextToImg(MemoryStream msc, MemoryStream ms, string text)
        {

            //还需要判断文件类型是否为图像类型，这里就不赘述了
            System.Drawing.Image image = System.Drawing.Image.FromStream(msc);
            Bitmap bitmap = new Bitmap(image, image.Width, image.Height);
            Graphics g = Graphics.FromImage(bitmap);

            float fontSize = 20.0f;             //字体大小
            float textWidth = text.Length * fontSize;  //文本的长度
                                                       //下面定义一个矩形区域，以后在这个矩形里画上白底黑字

            float rectWidth = text.Length * (fontSize + 8);
            float rectHeight = fontSize + 8;
            float rectX = (image.Width - rectWidth) / 2;
            float rectY = (image.Height - rectHeight) / 2;
            //声明矩形域
            RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);

            Font font = new Font("宋体", fontSize);   //定义字体
            Brush whiteBrush = new SolidBrush(Color.Red);   //白笔刷，画文字用
            Brush blackBrush = new SolidBrush(Color.Black);   //黑笔刷，画背景用

            // g.FillRectangle(blackBrush, rectX, rectY, rectWidth, rectHeight);

            g.DrawString(text, font, whiteBrush, textArea);

            //保存为Jpg类型
            bitmap.Save(ms, ImageFormat.Jpeg);
            g.Dispose();
            bitmap.Dispose();
            image.Dispose();
        }


        /// <summary>
        /// 生成带文字的二维码 的base64为
        /// </summary>
        /// <param name="inputText">需要生成二维码的字符串</param>
        /// <param name="showstr">二维码中间的展示文字</param>
        /// <param name="pixelsPerModule">二维码大小</param>
        /// <returns></returns>
        public  string GetQRCodeImageAsBase64(string inputText, string showstr, int pixelsPerModule = 10)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                CreateQRCode(inputText, ms);
                using (var msc = new System.IO.MemoryStream())
                {
                    AddTextToImg(ms, msc, showstr);
                    string str = Convert.ToBase64String(msc.ToArray());
                    return str;
                }
            }
        }



    }
}
