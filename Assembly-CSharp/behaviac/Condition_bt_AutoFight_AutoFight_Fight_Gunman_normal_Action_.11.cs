﻿using System;

namespace behaviac
{
	// Token: 0x020021DE RID: 8670
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Fight_Gunman_normal_Action_node27 : Condition
	{
		// Token: 0x06012D4A RID: 77130 RVA: 0x0058A9EA File Offset: 0x00588DEA
		public Condition_bt_AutoFight_AutoFight_Fight_Gunman_normal_Action_node27()
		{
			this.opl_p0 = 0.6f;
		}

		// Token: 0x06012D4B RID: 77131 RVA: 0x0058AA00 File Offset: 0x00588E00
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C73D RID: 51005
		private float opl_p0;
	}
}
