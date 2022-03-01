﻿using System;

namespace behaviac
{
	// Token: 0x020024A7 RID: 9383
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Gungirl_Action_node13 : Condition
	{
		// Token: 0x06013299 RID: 78489 RVA: 0x005B0166 File Offset: 0x005AE566
		public Condition_bt_AutoFight_AutoFight_Gungirl_Action_node13()
		{
			this.opl_p0 = 2000;
			this.opl_p1 = 500;
			this.opl_p2 = 1000;
			this.opl_p3 = 1000;
		}

		// Token: 0x0601329A RID: 78490 RVA: 0x005B019C File Offset: 0x005AE59C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CCB1 RID: 52401
		private int opl_p0;

		// Token: 0x0400CCB2 RID: 52402
		private int opl_p1;

		// Token: 0x0400CCB3 RID: 52403
		private int opl_p2;

		// Token: 0x0400CCB4 RID: 52404
		private int opl_p3;
	}
}
