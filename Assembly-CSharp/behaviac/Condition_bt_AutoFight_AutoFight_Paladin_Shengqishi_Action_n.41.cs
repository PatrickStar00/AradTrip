﻿using System;

namespace behaviac
{
	// Token: 0x02002848 RID: 10312
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Paladin_Shengqishi_Action_node9 : Condition
	{
		// Token: 0x060139CE RID: 80334 RVA: 0x005D9B69 File Offset: 0x005D7F69
		public Condition_bt_AutoFight_AutoFight_Paladin_Shengqishi_Action_node9()
		{
			this.opl_p0 = 0.45f;
		}

		// Token: 0x060139CF RID: 80335 RVA: 0x005D9B7C File Offset: 0x005D7F7C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D428 RID: 54312
		private float opl_p0;
	}
}
