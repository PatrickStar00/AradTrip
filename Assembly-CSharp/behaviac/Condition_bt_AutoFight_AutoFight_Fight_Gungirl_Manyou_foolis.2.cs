﻿using System;

namespace behaviac
{
	// Token: 0x02001FE8 RID: 8168
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Fight_Gungirl_Manyou_foolish_Action_node52 : Condition
	{
		// Token: 0x0601296C RID: 76140 RVA: 0x0057304F File Offset: 0x0057144F
		public Condition_bt_AutoFight_AutoFight_Fight_Gungirl_Manyou_foolish_Action_node52()
		{
			this.opl_p0 = 2500;
			this.opl_p1 = 500;
			this.opl_p2 = 1000;
			this.opl_p3 = 1000;
		}

		// Token: 0x0601296D RID: 76141 RVA: 0x00573084 File Offset: 0x00571484
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C35D RID: 50013
		private int opl_p0;

		// Token: 0x0400C35E RID: 50014
		private int opl_p1;

		// Token: 0x0400C35F RID: 50015
		private int opl_p2;

		// Token: 0x0400C360 RID: 50016
		private int opl_p3;
	}
}
