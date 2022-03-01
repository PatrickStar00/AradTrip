﻿using System;

namespace behaviac
{
	// Token: 0x02002A66 RID: 10854
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Guanka_apc_guijian_lun_node5 : Condition
	{
		// Token: 0x06013DF4 RID: 81396 RVA: 0x005F4D64 File Offset: 0x005F3164
		public Condition_bt_Guanka_apc_guijian_lun_node5()
		{
			this.opl_p0 = BE_Target.Enemy;
			this.opl_p1 = BE_Equal.NotEqual;
			this.opl_p2 = BE_State.DAODI;
		}

		// Token: 0x06013DF5 RID: 81397 RVA: 0x005F4D84 File Offset: 0x005F3184
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckState(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D867 RID: 55399
		private BE_Target opl_p0;

		// Token: 0x0400D868 RID: 55400
		private BE_Equal opl_p1;

		// Token: 0x0400D869 RID: 55401
		private BE_State opl_p2;
	}
}
