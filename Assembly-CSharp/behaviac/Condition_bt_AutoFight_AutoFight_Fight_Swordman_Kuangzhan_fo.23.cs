﻿using System;

namespace behaviac
{
	// Token: 0x02002355 RID: 9045
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node48 : Condition
	{
		// Token: 0x06013017 RID: 77847 RVA: 0x0059ED46 File Offset: 0x0059D146
		public Condition_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node48()
		{
			this.opl_p0 = 0.28f;
		}

		// Token: 0x06013018 RID: 77848 RVA: 0x0059ED5C File Offset: 0x0059D15C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CA2D RID: 51757
		private float opl_p0;
	}
}
