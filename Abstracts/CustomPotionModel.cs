using BaseLib.Patches;
using BaseLib.Patches.Content;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

public abstract class CustomPotionModel : PotionModel, ICustomModel
{
    public virtual bool AutoAdd => true;
    public CustomPotionModel()
    {
        if (AutoAdd) CustomContentDictionary.AddModel(GetType());
    }

    public virtual string PackedImagePath => ImageHelper.GetImagePath("atlases/potion_atlas.sprites/fire_potion.tres");
    public virtual string PackedOutlinePath => ImageHelper.GetImagePath("atlases/potion_outline_atlas.sprites/fire_potion.tres");
}
