﻿using System;

namespace behaviac
{
	// Token: 0x02003058 RID: 12376
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_BOSS_DestinationSelect_BOSS_DestinationSelect_2_5_0kelahe_DestinationSelect_node34 : Condition
	{
		// Token: 0x06014977 RID: 84343 RVA: 0x00632BDB File Offset: 0x00630FDB
		public Condition_bt_Monster_AI_BOSS_DestinationSelect_BOSS_DestinationSelect_2_5_0kelahe_DestinationSelect_node34()
		{
			this.opl_p0 = 15000;
			this.opl_p1 = 15000;
			this.opl_p2 = 15000;
			this.opl_p3 = 15000;
		}

		// Token: 0x06014978 RID: 84344 RVA: 0x00632C10 File Offset: 0x00631010
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E2D4 RID: 58068
		private int opl_p0;

		// Token: 0x0400E2D5 RID: 58069
		private int opl_p1;

		// Token: 0x0400E2D6 RID: 58070
		private int opl_p2;

		// Token: 0x0400E2D7 RID: 58071
		private int opl_p3;
	}
}
