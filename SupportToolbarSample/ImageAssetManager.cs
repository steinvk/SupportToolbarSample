using System;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics.Drawables;

namespace SupportToolbarSample
{
    public static class ImageAssetManager
    {
        static Dictionary<string, Drawable> cache = new Dictionary<string, Drawable>();

        public static Drawable Get(Context context, string url)
        {
            if(!cache.ContainsKey(url))
            {
                var drawables = Drawable.CreateFromStream(context.Assets.Open(url), null);
                cache.Add(url, drawables);
            }
            return cache[url];
        }
    }
}
