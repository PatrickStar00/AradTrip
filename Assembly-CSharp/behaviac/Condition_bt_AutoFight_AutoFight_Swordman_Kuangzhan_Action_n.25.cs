﻿using System;

namespace behaviac
{
	// Token: 0x02002964 RID: 10596
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Swordman_Kuangzhan_Action_node55 : Condition
	{
		// Token: 0x06013BFD RID: 80893 RVA: 0x005E7912 File Offset: 0x005E5D12
		public Condition_bt_AutoFight_AutoFight_Swordman_Kuangzhan_Action_node55()
		{
			this.opl_p0 = 2000;
			this.opl_p1 = 2000;
			this.opl_p2 = 1000;
			this.opl_p3 = 1000;
		}

		// Token: 0x06013BFE RID: 80894 RVA: 0x005E7948 File Offset: 0x005E5D48
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D662 RID: 54882
		private int opl_p0;

		// Token: 0x0400D663 RID: 54883
		private int opl_p1;

		// Token: 0x0400D664 RID: 54884
		private int opl_p2;

		// Token: 0x0400D665 RID: 54885
		private int opl_p3;
	}
}
