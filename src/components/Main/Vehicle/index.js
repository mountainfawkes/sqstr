import yugos from '../../../Data/Yugos'

export default () => (
  <>
    <h3>This is the vehicle travel form.</h3>
    <form>
      <input type='hidden' value='vehicle' />
      <label htmlFor='distance_unit'>Unit of measurement:
        <select name='distance_unit' placeholder='Miles'>
          <option value='mi'>Miles</option>
          <option value='km'>Kilometers</option>
        </select>
      </label>
      <label htmlFor='distance_value'>
        <input type='number' name='distance_value' />
      </label>
      <label htmlFor='fuel_source_value'>Amount used in BTU:
        <input type='number' step='0.1' min='0' name='fuel_source_value' />
      </label>
      <label htmlFor='vehicle_model_id'>Vehicle make and model:
        <select name='vehicle_model_id' placeholder='Find your make and model'>
          {yugos.map(yugo =>
            <option value={yugo.id}>
              {
              yugo.attributes.year
              } {
              yugo.attributes.vehicle_make
              } {
              yugo.attributes.name
              }
            </option>)}
        </select>
      </label>
      <button type='submit'>Estimate</button>
    </form>
  </>
)
