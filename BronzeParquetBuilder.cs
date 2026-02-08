/*
 * Project: DatabaseBuilder
 * Author: Eric C. Grasby, MSIQ
 * Contact: ecgrasby@ualr.edu
 *
 * Class Name: BronzeParquetBuilder
 *
 * Description: Parquet-file builder for the bronze layer of the medallion data architecture
 *
 * License: GPL-3.0-or-later
 * 
 * This file is used as a utility in support of the author's dissertation work:
 * "A Domain-Specific Language Approach to Monitoring and Surveillance Operations Within Wholesale Electricity Markets"
 * It is distributed under the GNU General Public License v3.0 (GPL-3.0-or-later).
 * You should have received a copy of the GPL along with this project.
 * If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Parquet;
using Parquet.Data;
using Parquet.Schema;

namespace DatabaseBuilder
{


    class BronzeParquetBuilder
    {
        public BronzeParquetBuilder() { }
        
        public void test()
        {
            //var plantId = new DataField<int>("plant_id");
        }

    }
 }
