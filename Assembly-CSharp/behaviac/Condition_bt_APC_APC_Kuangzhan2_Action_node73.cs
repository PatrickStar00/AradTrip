﻿using System;

namespace behaviac
{
	// Token: 0x02001D8B RID: 7563
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_APC_APC_Kuangzhan2_Action_node73 : Condition
	{
		// Token: 0x060124D1 RID: 74961 RVA: 0x00557393 File Offset: 0x00555793
		public Condition_bt_APC_APC_Kuangzhan2_Action_node73()
		{
			this.opl_p0 = 0.1f;
		}

		// Token: 0x060124D2 RID: 74962 RVA: 0x005573A8 File Offset: 0x005557A8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400BEBE RID: 48830
		private float opl_p0;
	}
}
