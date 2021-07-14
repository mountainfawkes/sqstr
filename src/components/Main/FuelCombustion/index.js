import fuels from "../../../Data/Fuels"

export default () => (
  <div>
    <h3>This is the fuel combustion form</h3>
    <form onSubmit='undefined'>
      <input type='hidden' value='fuel_combustion' />
      <label htmlFor='fuel_source_type'>Type of fuel:
        <select name='fuel_source_type'>
          {fuels.forEach(fuel =>
            <option value={fuel.fuel_source_type}>{fuel.name}</option>
          )}
        </select>
      </label>
      <input type='hidden' name='fuel_source_unit' value='btu' />
      <label htmlFor='fuel_source_value'>Amount used in BTU:
        <input type='number' step='0.1' name='fuel_source_value' />
      </label>
      <button type='submit'>Estimate</button>
    </form>
  </div>
)
