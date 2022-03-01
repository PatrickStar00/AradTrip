﻿using System;

namespace behaviac
{
	// Token: 0x02003013 RID: 12307
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_BOSS_DestinationSelect_BOSS_DestinationSelect_2_3_0luoleikainuo_DestinationSelect_node14 : Condition
	{
		// Token: 0x060148EF RID: 84207 RVA: 0x0063054F File Offset: 0x0062E94F
		public Condition_bt_Monster_AI_BOSS_DestinationSelect_BOSS_DestinationSelect_2_3_0luoleikainuo_DestinationSelect_node14()
		{
			this.opl_p0 = 3000;
			this.opl_p1 = 3000;
			this.opl_p2 = 3000;
			this.opl_p3 = 3000;
		}

		// Token: 0x060148F0 RID: 84208 RVA: 0x00630584 File Offset: 0x0062E984
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E24C RID: 57932
		private int opl_p0;

		// Token: 0x0400E24D RID: 57933
		private int opl_p1;

		// Token: 0x0400E24E RID: 57934
		private int opl_p2;

		// Token: 0x0400E24F RID: 57935
		private int opl_p3;
	}
}
