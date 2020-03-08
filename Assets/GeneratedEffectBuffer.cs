//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wayn.Mgm.Effects.Generated
{
    
    
    public struct EffectQueueReferences
    {
        
        private Unity.Collections.NativeQueue<Wayn.Mgm.Combat.Effects.ChangeHealthEffect>.ParallelWriter writerChangeHealthEffect;
        
        private Unity.Collections.NativeQueue<Wayn.Mgm.Combat.Effects.DestroyEntityHierarchyEffect>.ParallelWriter writerDestroyEntityHierarchyEffect;
        
        private Unity.Collections.NativeQueue<Wayn.Mgm.Combat.Effects.DisableEntityHierarchyEffect>.ParallelWriter writerDisableEntityHierarchyEffect;
        
        public EffectQueueReferences(Unity.Entities.World world)
        {
            writerChangeHealthEffect = world.GetOrCreateSystem<Wayn.Mgm.Combat.Effects.ChangeHealthEffectConsumerSystem>().GetConsumerQueue();
            writerDestroyEntityHierarchyEffect = world.GetOrCreateSystem<Wayn.Mgm.Combat.Effects.DestroyEntityHirearchyEffectConsumerSystem>().GetConsumerQueue();
            writerDisableEntityHierarchyEffect = world.GetOrCreateSystem<Wayn.Mgm.Combat.Effects.DisableEntityHierarchyEffectConsumerSystem>().GetConsumerQueue();
        }
        
        public void Enqueue(Wayn.Mgm.Combat.Effects.ChangeHealthEffect effect, Unity.Entities.Entity other, Unity.Entities.Entity emmiter)
        {
            effect.Emmiter = emmiter ;
            effect.Other = other ;
            writerChangeHealthEffect.Enqueue(effect) ;
        }
        
        public void Enqueue(Wayn.Mgm.Combat.Effects.DestroyEntityHierarchyEffect effect, Unity.Entities.Entity other, Unity.Entities.Entity emmiter)
        {
            effect.Emmiter = emmiter ;
            effect.Other = other ;
            writerDestroyEntityHierarchyEffect.Enqueue(effect) ;
        }
        
        public void Enqueue(Wayn.Mgm.Combat.Effects.DisableEntityHierarchyEffect effect, Unity.Entities.Entity other, Unity.Entities.Entity emmiter)
        {
            effect.Emmiter = emmiter ;
            effect.Other = other ;
            writerDisableEntityHierarchyEffect.Enqueue(effect) ;
        }
    }
    
    public struct EffectRegistry
    {
        
        public Unity.Collections.NativeList<Wayn.Mgm.Combat.Effects.ChangeHealthEffect> nativeListOfChangeHealthEffect;
        
        public Unity.Collections.NativeList<Wayn.Mgm.Combat.Effects.DestroyEntityHierarchyEffect> nativeListOfDestroyEntityHierarchyEffect;
        
        public Unity.Collections.NativeList<Wayn.Mgm.Combat.Effects.DisableEntityHierarchyEffect> nativeListOfDisableEntityHierarchyEffect;
        
        public EffectRegistry(int defaultAllocationSize)
        {
            nativeListOfChangeHealthEffect = new Unity.Collections.NativeList<Wayn.Mgm.Combat.Effects.ChangeHealthEffect>(defaultAllocationSize,Unity.Collections.Allocator.Persistent);
            nativeListOfDestroyEntityHierarchyEffect = new Unity.Collections.NativeList<Wayn.Mgm.Combat.Effects.DestroyEntityHierarchyEffect>(defaultAllocationSize,Unity.Collections.Allocator.Persistent);
            nativeListOfDisableEntityHierarchyEffect = new Unity.Collections.NativeList<Wayn.Mgm.Combat.Effects.DisableEntityHierarchyEffect>(defaultAllocationSize,Unity.Collections.Allocator.Persistent);
        }
        
        public int AddEffectVerion(Wayn.Mgm.Effects.IEffect effect)
        {
            switch(effect)
            {
               case Wayn.Mgm.Combat.Effects.ChangeHealthEffect e:
                   nativeListOfChangeHealthEffect.Add(e);
                   return nativeListOfChangeHealthEffect.Length - 1;
               case Wayn.Mgm.Combat.Effects.DestroyEntityHierarchyEffect e:
                   nativeListOfDestroyEntityHierarchyEffect.Add(e);
                   return nativeListOfDestroyEntityHierarchyEffect.Length - 1;
               case Wayn.Mgm.Combat.Effects.DisableEntityHierarchyEffect e:
                   nativeListOfDisableEntityHierarchyEffect.Add(e);
                   return nativeListOfDisableEntityHierarchyEffect.Length - 1;
            }
;
            return 1;
        }
    }
    
    public struct EffectBuffer
    {
        
        private EffectQueueReferences effectQueueReferences;
        
        public EffectRegistry effectRegistry;
        
        public EffectBuffer(Unity.Entities.World world)
        {
            effectQueueReferences = new EffectQueueReferences(world);
            effectRegistry = new EffectRegistry(1);
        }
        
        public void Add(ulong effectTypeId, int effectVersionId, Unity.Entities.Entity other, Unity.Entities.Entity emmiter)
        {
            switch(effectTypeId)
            {
               case 3197214379069811340:
                   effectQueueReferences.Enqueue(effectRegistry.nativeListOfChangeHealthEffect[effectVersionId], other, emmiter);
                    break;
               case 15432639814022543625:
                   effectQueueReferences.Enqueue(effectRegistry.nativeListOfDestroyEntityHierarchyEffect[effectVersionId], other, emmiter);
                    break;
               case 15023404359119180371:
                   effectQueueReferences.Enqueue(effectRegistry.nativeListOfDisableEntityHierarchyEffect[effectVersionId], other, emmiter);
                    break;
            }
;
        }
    }
}