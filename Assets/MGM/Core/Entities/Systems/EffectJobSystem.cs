﻿using Wayn.Mgm.Events;
using Unity.Entities;
using Unity.Jobs;
using Unity.Collections;

[UpdateBefore(typeof(EffectConsumerSystemGroup))]
public abstract class EffectJobSystem : JobComponentSystem
{

    protected EffectBufferSystem m_EffectBufferSystem;

    protected override void OnCreate()
    {
        base.OnCreate();

        m_EffectBufferSystem = World.GetOrCreateSystem<EffectBufferSystem>();


    }

    protected void AddJobHandleForConsumer(JobHandle job)
    {
        m_EffectBufferSystem.AddJobHandleForConsumer(job);
    }

}
