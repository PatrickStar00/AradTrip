﻿using System;

namespace behaviac
{
	// Token: 0x02003094 RID: 12436
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_BOSS_DestinationSelect_BOSS_DestinationSelect_2_8_0guyuxi_DestinationSelect_node9 : Condition
	{
		// Token: 0x060149EC RID: 84460 RVA: 0x0063579F File Offset: 0x00633B9F
		public Condition_bt_Monster_AI_BOSS_DestinationSelect_BOSS_DestinationSelect_2_8_0guyuxi_DestinationSelect_node9()
		{
			this.opl_p0 = 0.5f;
		}

		// Token: 0x060149ED RID: 84461 RVA: 0x006357B4 File Offset: 0x00633BB4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E349 RID: 58185
		private float opl_p0;
	}
}
