namespace UnityGLTF.Plugins
{
    public class AnimationPointerExport: GltfExportPlugin
    {
        public override string DisplayName => "KHR_animation_pointer";
        public override string Description => "Animate arbitrary material and object properties. Without this extension, only node transforms and blend shape weights can be animated.";
        public override bool EnabledByDefault => false;
        public override GltfExportPluginContext CreateInstance(ExportContext context)
        {
            return new AnimationPointerExportContext();
        }
    }
    
    public class AnimationPointerExportContext: GltfExportPluginContext
    {
        
    }
}