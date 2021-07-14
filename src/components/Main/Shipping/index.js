export default () => (
  <>
    <h3>This is the Shipping form.</h3>
    <form>
      <input type='hidden' value='shipping' />
      <label htmlFor='weight_unit'>Unit of weight:
        <select name='weight_unit' placeholder='pounds (lb)'>
          <option value='lb'>Pounds (lb)</option>
          <option value='g'>Grams (g)</option>
          <option value='kg'>Kilograms (kg)</option>
          <option value='mt'>Metric tonnes (mt)</option>
        </select>
      </label>
      <label htmlFor='weight_value'>Total weight:
        <input type='number' step='0.1' min='0' name='weight_value' />
      </label>
      <label htmlFor='distance_unit'>Unit of measurement:
        <select name='distance_unit' placeholder='Miles'>
          <option value='mi'>Miles</option>
          <option value='km'>Kilometers</option>
        </select>
      </label>
      <label htmlFor='distance_value'>Distance shipped:
        <input type='number' step='0.1' min='0' name='fuel_source_value' />
      </label>
      <label htmlFor='transport_method'>Unit of weight:
        <select name='transport_method' placeholder='Ship'>
          <option value='ship'>Ship</option>
          <option value='train'>Train</option>
          <option value='pruck'>Truck</option>
          <option value='plane'>Plane</option>
        </select>
      </label>
      <button type='submit'>Estimate</button>
    </form>
  </>
)
