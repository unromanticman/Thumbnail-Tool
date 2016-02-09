using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;

namespace Thumbnail
{
    class API
    {
        public static int[] GetThumbPic_Width(System.Drawing.Image image, int maxWidth)
        {
            //要回傳的結果
            int fixWidth = 0;
            int fixHeight = 0;

            if (image.Width > maxWidth)
            //如果圖片的寬大於最大值 
            {


                //等比例的圖高
                fixHeight = Convert.ToInt32((Convert.ToDouble(maxWidth) / Convert.ToDouble(image.Width)) * Convert.ToDouble(image.Height));
                //設定修改後的圖寬  
                fixWidth = maxWidth;

            }
            else
            {//圖片寬沒有超過設定值，不執行縮圖  

                fixHeight = image.Height;

                fixWidth = image.Width;

            }

            int[] fixWidthAndfixHeight = { fixWidth, fixHeight };

            return fixWidthAndfixHeight;
        }
        public static int[] GetThumbPic_Height(System.Drawing.Image image, int maxHeight)
        {
            //要回傳的值
            int fixWidth = 0;
            int fixHeight = 0;

            if (image.Height > maxHeight)
            //如果圖片的高大於最大值 
            {
                //等比例的寬
                fixWidth = Convert.ToInt32((Convert.ToDouble(maxHeight) / Convert.ToDouble(image.Height)) * Convert.ToDouble(image.Width));
                //圖高固定  
                fixHeight = maxHeight;

            }
            else
            {//圖片的高沒有超過設定值 

                fixHeight = image.Height;

                fixWidth = image.Width;

            }

            int[] fixWidthAndfixHeight = { fixWidth, fixHeight };

            return fixWidthAndfixHeight;
        }
      

        public static void SaveThumbPicScale(string srcImagePath, double scale, string saveThumbFilePath)
        {

            //讀取原始圖片 
            using (FileStream fs = new FileStream(srcImagePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                GC.Collect();
                //取得原始圖片 
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fs);

                //圖片寬高
                int ImgWidth = bitmap.Width;
                int ImgHeight = bitmap.Height;

                // 計算維持比例的縮圖大小 
                int[] thumbnailScaleWidth = GetThumbPic_Height(bitmap, (int)(scale * ImgHeight));
                int AfterImgWidth = thumbnailScaleWidth[0];
                int AfterImgHeight = thumbnailScaleWidth[1];
                GC.Collect();
                // 產生縮圖 
                using (var bmp = new Bitmap(AfterImgWidth, AfterImgHeight))
                {
                    using (var gr = Graphics.FromImage(bmp))
                    {

                        gr.CompositingQuality = CompositingQuality.HighQuality;
                        gr.SmoothingMode = SmoothingMode.HighQuality;
                        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gr.DrawImage(bitmap, new Rectangle(0, 0, AfterImgWidth, AfterImgHeight), 0, 0, ImgWidth, ImgHeight, GraphicsUnit.Pixel);
                        bmp.Save(saveThumbFilePath);
                        GC.Collect();
                    }
                    GC.Collect();
                }

            }
        }
        public static void SaveThumbPicWidth(string srcImagePath, int widthMaxPix, string saveThumbFilePath)
        {
            //讀取原始圖片 
            using (FileStream fs = new FileStream(srcImagePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                //取得原始圖片 
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fs);

                //圖片寬高
                int ImgWidth = bitmap.Width;
                int ImgHeight = bitmap.Height;
                // 計算維持比例的縮圖大小 
                int[] thumbnailScaleWidth = GetThumbPic_Width(bitmap, widthMaxPix);
                int AfterImgWidth = thumbnailScaleWidth[0];
                int AfterImgHeight = thumbnailScaleWidth[1];

                // 產生縮圖 
                using (var bmp = new Bitmap(AfterImgWidth, AfterImgHeight))
                {
                    using (var gr = Graphics.FromImage(bmp))
                    {

                        gr.CompositingQuality = CompositingQuality.HighQuality;
                        gr.SmoothingMode = SmoothingMode.HighQuality;
                        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gr.DrawImage(bitmap, new Rectangle(0, 0, AfterImgWidth, AfterImgHeight), 0, 0, ImgWidth, ImgHeight, GraphicsUnit.Pixel);
                        bmp.Save(saveThumbFilePath);
                    }
                }



            }
        }
        public static void SaveThumbPicHeight(string srcImagePath, int heightMaxPix, string saveThumbFilePath)
        {
            //讀取原始圖片 
            using (FileStream fs = new FileStream(srcImagePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                //取得原始圖片 
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fs);

                //圖片寬高
                int ImgWidth = bitmap.Width;
                int ImgHeight = bitmap.Height;
                // 計算維持比例的縮圖大小 
                int[] thumbnailScaleWidth = GetThumbPic_Height(bitmap, heightMaxPix);
                int AfterImgWidth = thumbnailScaleWidth[0];
                int AfterImgHeight = thumbnailScaleWidth[1];

                // 產生縮圖 
                using (var bmp = new Bitmap(AfterImgWidth, AfterImgHeight))
                {
                    using (var gr = Graphics.FromImage(bmp))
                    {

                        gr.CompositingQuality = CompositingQuality.HighQuality;
                        gr.SmoothingMode = SmoothingMode.HighQuality;
                        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gr.DrawImage(bitmap, new Rectangle(0, 0, AfterImgWidth, AfterImgHeight), 0, 0, ImgWidth, ImgHeight, GraphicsUnit.Pixel);
                        bmp.Save(saveThumbFilePath);
                    }
                }



            }
        }

    }
}
